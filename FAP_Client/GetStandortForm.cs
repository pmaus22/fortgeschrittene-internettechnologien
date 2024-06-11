using DevExpress.XtraMap;
using FAP_Client.Models;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

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

        // BindingLists for user list and heatmap
        private static readonly BindingList<string> UserList = new BindingList<string>();
        private static readonly BindingList<Standort> LocationList = new BindingList<Standort>();

        public GetStandortForm()
        {
            InitializeComponent();
            labelHeader.Text = "Herzlich willkommen, " + CurrentLoginName + "!";

            adapter = new HeatmapDataSourceAdapter();
            adapter.Mappings.XCoordinate = "laengengrad";
            adapter.Mappings.YCoordinate = "breitengrad";

            provider = new HeatmapProvider();
            provider.PointSource = adapter;
            provider.Algorithm = new HeatmapDensityBasedAlgorithm { PointRadius = 6 };

            ImageLayer heatmapLayer = new ImageLayer();
            heatmapLayer.DataProvider = provider;
            mapControl.Layers.Add(heatmapLayer);

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
            listBoxUserList.DataSource = UserList;
            adapter.DataSource = LocationList;

            //TODO: auto refresh locations
        }

        public async static void RefreshLocationList()
        {
            // Get location for every user in the list
            for (int i = 0; i < UserList.Count; i++)
            {
                var standort = await Program.GetStandortAsync(CurrentLoginName, CurrentSessionID, UserList[i]);
                LocationList[i] = standort;
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
            //TODO: vorname und nachname zeigen

            // Check if UserId is already in the list
            if (!UserList.Contains(textBoxUserId.Text))
            {
                // Get location for the entered username
                var standort = await Program.GetStandortAsync(CurrentLoginName, CurrentSessionID, textBoxUserId.Text);

                // Show error message if server responds with null or empty json object
                if (standort == null || (standort.breitengrad == 0 && standort.laengengrad == 0))
                {
                    labelMessageGetUser.Text = "⚠️ Der Nutzer existiert nicht oder hat keinen Standort angegeben";
                }

                // Add user to list and map, clear error message
                else
                {
                    UserList.Add(textBoxUserId.Text);
                    LocationList.Add(standort);
                    labelMessageGetUser.ResetText();
                }
            }

            // Show error message when UserId is already in the list
            else
            {
                labelMessageGetUser.Text = "⚠️ Der Nutzer steht bereits in der Liste";
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
                labelMessageZoom.Text = "⚠️ Es ist kein Nutzer zum heranzoomen ausgewählt";
            }
        }

        private void GetStandortForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Exit app when main window is closed
            Application.Exit();
        }
    }
}
