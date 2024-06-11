﻿using DevExpress.XtraMap;
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
            labelHeader.Text = "Herzlich willkommen, " + CurrentLoginName + "!";


            adapter = new HeatmapDataSourceAdapter();
            adapter.Mappings.XCoordinate = "lon"; //lon
            adapter.Mappings.YCoordinate = "lat"; //lat

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

            grdUserIds.DataSource = SelectedUsers;
            adapter.DataSource = SelectedUsers;
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
            // TODO: Dont allow double entry
            // TODO: Auto refresh location of every user in the list
            // Get location for the entered username
            var standort = await Program.GetStandortAsync(CurrentLoginName, CurrentSessionID, textBoxUserId.Text);

            // Show error message if server responds with null or empty json object
            if (standort == null || (standort.breitengrad == 0 && standort.laengengrad == 0))
            {
                labelMessage.Text = "Der Nutzer existiert nicht oder hat keinen Standort angegeben.";
            }

            // Add user to grid and map
            else
            {
                SelectedUsers.Add(new StandortMapData { UserID = textBoxUserId.Text, lat = standort.breitengrad, lon = standort.laengengrad });
                grdUserIds.DataSource = SelectedUsers;
                adapter.DataSource = SelectedUsers;
                gridViewUserIDs.RefreshData();
                adapter.Load();
            }
        }

        private void buttonZoom_Click(object sender, EventArgs e)
        {
            // TODO: Error handling when no user is selected
            var currDataRow = (string)gridViewUserIDs.GetFocusedRowCellValue(gridViewUserIDs.Columns["UserID"]);
            var currUser = SelectedUsers.FirstOrDefault(x => x.UserID == currDataRow);
            mapControl.CenterPoint = new DevExpress.XtraMap.GeoPoint(currUser.lat, currUser.lon);
            mapControl.ZoomLevel = 15.2D;
        }
    }
}
