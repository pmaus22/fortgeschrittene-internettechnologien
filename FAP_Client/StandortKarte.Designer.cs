namespace FAP_Client
{
    partial class StandortKarte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.wmsDataProvider1 = new DevExpress.XtraMap.WmsDataProvider();
            this.imageLayer2 = new DevExpress.XtraMap.ImageLayer();
            this.heatmapProvider1 = new DevExpress.XtraMap.HeatmapProvider();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // mapControl1
            // 
            this.mapControl1.CenterPoint = new DevExpress.XtraMap.GeoPoint(50.5D, 10D);
            this.mapControl1.Layers.Add(this.imageLayer1);
            this.mapControl1.Layers.Add(this.imageLayer2);
            this.mapControl1.Location = new System.Drawing.Point(-1, -1);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(744, 530);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.ZoomLevel = 5.8D;
            this.imageLayer1.DataProvider = this.wmsDataProvider1;
            this.imageLayer1.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            this.imageLayer1.Name = "WmsMap";
            this.wmsDataProvider1.ActiveLayerName = "OSM-WMS";
            this.wmsDataProvider1.ServerUri = "http://ows.mundialis.de/services/service?";
            this.imageLayer2.DataProvider = this.heatmapProvider1;
            // 
            // StandortKarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 530);
            this.Controls.Add(this.mapControl1);
            this.Name = "StandortKarte";
            this.Text = "StandortKarte";
            this.Load += new System.EventHandler(this.StandortKarte_FormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraMap.MapControl mapControl1;
        private DevExpress.XtraMap.ImageLayer imageLayer1;
        private DevExpress.XtraMap.WmsDataProvider wmsDataProvider1;
        private DevExpress.XtraMap.ImageLayer imageLayer2;
        private DevExpress.XtraMap.HeatmapProvider heatmapProvider1;
    }
}