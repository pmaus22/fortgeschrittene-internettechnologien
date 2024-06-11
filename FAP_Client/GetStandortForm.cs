using DevExpress.XtraMap;
using FAP_Client.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FAP_Client
{
    public partial class GetStandortForm : Form
    {
        // Variables to save login name and session ID of logged in user
        public static string CurrentLoginName;
        public static string CurrentSessionID;
        HeatmapDataSourceAdapter adapter;
        HeatmapProvider provider;


        private List<StandortMapData> SelectedUsers = new List<StandortMapData>();

        public GetStandortForm()
        {
            InitializeComponent();
            labelLoginName.Text = "Angemeldet als: " + CurrentLoginName;


            adapter = new HeatmapDataSourceAdapter();
            adapter.Mappings.XCoordinate = "lon"; //lon
            adapter.Mappings.YCoordinate = "lat"; //lat

            provider = new HeatmapProvider();
            provider.PointSource = adapter;
            provider.Algorithm = new HeatmapDensityBasedAlgorithm { PointRadius = 6 };

            ImageLayer heatmapLayer = new ImageLayer();
            heatmapLayer.DataProvider = provider;
            mapControl1.Layers.Add(heatmapLayer);


            ChoroplethColorizer colorizer = new ChoroplethColorizer();
            colorizer.RangeStops.AddRange(new double[] { 0.1, 0.3, 0.5, 0.7, 1 });
            colorizer.ColorItems.Add(new ColorizerColorItem(Color.Green));
            colorizer.ColorItems.Add(new ColorizerColorItem(Color.YellowGreen));
            colorizer.ColorItems.Add(new ColorizerColorItem(Color.Yellow));
            colorizer.ColorItems.Add(new ColorizerColorItem(Color.Orange));
            colorizer.ColorItems.Add(new ColorizerColorItem(Color.Red));
            colorizer.ApproximateColors = true;

            provider.Colorizer = colorizer;
            // Werte noch löschen sind nur für den Test da
            SelectedUsers.Add(new StandortMapData { UserID = "Peter", lat = 51.8384, lon = 6.6151 });
            SelectedUsers.Add(new StandortMapData { UserID = "Hans", lat = 52.8384, lon = 7.6151 });
            SelectedUsers.Add(new StandortMapData { UserID = "Jürgen", lat = 54.8384, lon = 6.1151 });
            SelectedUsers.Add(new StandortMapData { UserID = "Veselin", lat = 51.8233, lon = 6.7151 });
            SelectedUsers.Add(new StandortMapData { UserID = "mark", lat = 51.8555, lon = 9.9151 });
            SelectedUsers.Add(new StandortMapData { UserID = "mausiP", lat = 56.3343, lon = 6.6151 });
            grdUserIds.DataSource = SelectedUsers;
            adapter.DataSource = SelectedUsers;
        }
        internal async void GetUser()
        {
            var curStandort = await Program.GetStandortAsync(CurrentLoginName, CurrentSessionID, txtBoxAddUserTrack.Text);
            if (curStandort != null)
            {
                SelectedUsers.Add(new StandortMapData { UserID = txtBoxAddUserTrack.Text, lat = curStandort.breitengrad, lon = curStandort.laengengrad });
            }
            grdUserIds.DataSource = SelectedUsers;
            adapter.DataSource = SelectedUsers;
            gridViewUserIDs.RefreshData();
        }
        private void buttonLogout_Click(object sender, EventArgs e)
        {
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

        private void btnAddUserTrack_Click(object sender, EventArgs e)
        {
            GetUser();
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            var currDataRow = (string)gridViewUserIDs.GetFocusedRowCellValue(gridViewUserIDs.Columns["UserID"]);
            var currUser = SelectedUsers.FirstOrDefault(x => x.UserID == currDataRow);
            mapControl1.CenterPoint = new DevExpress.XtraMap.GeoPoint(currUser.lat, currUser.lon);
            mapControl1.ZoomLevel = 15.2D;
        }
    }
}
