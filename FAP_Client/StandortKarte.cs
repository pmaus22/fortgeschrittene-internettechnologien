using DevExpress.XtraMap;
using FAP_Client.Models;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace FAP_Client
{
    internal partial class StandortKarte : DevExpress.XtraEditors.XtraForm
    {
        HeatmapDataSourceAdapter adapter;
        HeatmapProvider provider;
        private List<StandortMapData> MainDataSource = new List<StandortMapData>();
        private StandortKarte(List<StandortMapData> piStandorte)
        {
            InitializeComponent();

            MainDataSource = piStandorte;

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
        }


        private void StandortKarte_FormLoad(object sender, EventArgs e)
        {
            adapter.DataSource = MainDataSource;
        }
    }
}