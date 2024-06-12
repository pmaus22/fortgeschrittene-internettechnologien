using DevExpress.XtraMap;
using FAP_Client.Models;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Linq;
using System.Collections.Generic;

namespace FAP_Client
{
    public partial class GetStandortForm : Form
    {
        // Variables to save login name and session ID of logged in user
        public static string CurrentLoginName;
        public static string CurrentSessionID;

        // Objects for map visuals
        private readonly HeatmapDataSourceAdapter adapter;
        private readonly HeatmapProvider provider;

        // List to store user data for logical operations
        private static readonly List<User> UserList = new List<User>();

        // BindingLists for user list box and heatmap
        private readonly BindingList<string> UserListDisplayItems = new BindingList<string>();
        private static readonly BindingList<Standort> LocationList = new BindingList<Standort>();

        public GetStandortForm()
        {
            InitializeComponent();
            labelHeader.Text = "Herzlich willkommen, " + CurrentLoginName + "!";

            // Adapter object to map attributes of location object to
            adapter = new HeatmapDataSourceAdapter();
            adapter.Mappings.XCoordinate = "laengengrad";
            adapter.Mappings.YCoordinate = "breitengrad";

            // Heatmap provider
            provider = new HeatmapProvider();
            provider.PointSource = adapter;
            provider.Algorithm = new HeatmapDensityBasedAlgorithm { PointRadius = 6 };

            // Heatmap layer
            ImageLayer heatmapLayer = new ImageLayer();
            heatmapLayer.DataProvider = provider;
            mapControl.Layers.Add(heatmapLayer);

            // Define heatmap colors
            ChoroplethColorizer colorizer = new ChoroplethColorizer();
            colorizer.RangeStops.AddRange(new double[] { 0.1, 0.3, 0.5, 0.7, 1 });
            colorizer.ColorItems.Add(new ColorizerColorItem(Color.Green));
            colorizer.ColorItems.Add(new ColorizerColorItem(Color.YellowGreen));
            colorizer.ColorItems.Add(new ColorizerColorItem(Color.Yellow));
            colorizer.ColorItems.Add(new ColorizerColorItem(Color.Orange));
            colorizer.ColorItems.Add(new ColorizerColorItem(Color.Red));
            colorizer.ApproximateColors = true;
            provider.Colorizer = colorizer;

            // Use BindingLists as data sources for user list and heatmap to automatically refresh visuals when an item is added
            listBoxUserList.DataSource = UserListDisplayItems;
            adapter.DataSource = LocationList;
        }

        public async static void RefreshLocationList()
        {
            // Get location for every user in the list
            for (int i = 0; i < UserList.Count; i++)
            {
                var standort = await Program.GetStandortAsync(CurrentLoginName, CurrentSessionID, UserList[i].loginName);
                LocationList[i] = standort;
            }
        }

        private void buttonSetStandort_Click(object sender, EventArgs e)
        {
            // Open window to set location and pass user data
            SetStandortForm.CurrentLoginName = CurrentLoginName;
            SetStandortForm.CurrentSessionID = CurrentSessionID;
            SetStandortForm setStandort = new SetStandortForm();
            setStandort.Show();
        }

        private async void buttonGetUser_Click(object sender, EventArgs e)
        {
            // Check if UserId is already in the list
            if (!UserList.Any(u => u.loginName == textBoxUserId.Text))
            {
                // Send request to server to get user data
                var user = await Program.GetBenutzerAsync(CurrentLoginName, CurrentSessionID, textBoxUserId.Text);

                // Get location if user exists
                if (user != null)
                {
                    // Get location for the entered username
                    var standort = await Program.GetStandortAsync(CurrentLoginName, CurrentSessionID, textBoxUserId.Text);

                    // Show error message if server responds with null
                    if (standort == null)
                    {
                        labelMessageGetUser.Text = "⚠️ Der Nutzer hat keinen Standort angegeben";
                    }

                    // Add user to list and map, clear error message
                    else
                    {
                        UserList.Add(user);
                        UserListDisplayItems.Add($"{user.loginName} - {user.vorname} {user.nachname}");
                        LocationList.Add(standort);
                        labelMessageGetUser.ResetText();
                    }
                }

                // Show error message when user does not exist
                else
                {
                    labelMessageGetUser.Text = "⚠️ Der Nutzer existiert nicht";
                }
            }

            // Show error message when UserId is already in the list
            else
            {
                labelMessageGetUser.Text = "⚠️ Der Nutzer steht bereits in der Liste";
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            // Check if list is empty
            if (UserList.Count != 0)
            {
                // Get index of selected user
                var selectedIndex = listBoxUserList.SelectedIndex;

                // Remove selected user from list and location from map
                UserList.RemoveAt(selectedIndex);
                UserListDisplayItems.RemoveAt(selectedIndex);
                LocationList.RemoveAt(selectedIndex);

                // Clear error message
                labelMessageZoom.ResetText();
            }

            // Show error message
            else
            {
                labelMessageZoom.Text = "⚠️ Es ist kein Nutzer ausgewählt";
            }

        }

        private void buttonZoom_Click(object sender, EventArgs e)
        {
            // Check if list is empty
            if (UserList.Count != 0)
            {
                // Get index of selected user
                var selectedIndex = listBoxUserList.SelectedIndex;

                // Use index of selected user to find the corresponding location on the map
                mapControl.CenterPoint = new DevExpress.XtraMap.GeoPoint(LocationList[selectedIndex].breitengrad, LocationList[selectedIndex].laengengrad);
                mapControl.ZoomLevel = 15.2D;

                // Clear error message
                labelMessageZoom.ResetText();
            }

            // Show error message
            else
            {
                labelMessageZoom.Text = "⚠️ Es ist kein Nutzer ausgewählt";
            }
        }
        private async void buttonLogout_Click(object sender, EventArgs e)
        {
            // Create object with current session ID of logged in user
            var logoutBody = new LogoutBody
            {
                loginName = CurrentLoginName,
                sitzung = CurrentSessionID
            };

            // Send logout request to server
            await Program.LogoutAsync(logoutBody);

            // Clear user data, close main app and open login window
            CurrentSessionID = null;
            CurrentLoginName = null;
            this.Dispose();
            LoginForm login = new LoginForm();
            login.Show();
        }


        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            // Refresh Locations on button click event
            RefreshLocationList();
        }

        private void GetStandortForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Exit app when main window is closed
            Application.Exit();
        }
    }
}
