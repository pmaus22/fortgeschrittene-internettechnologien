namespace FAP_Client
{
    partial class GetStandortForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetStandortForm));
            this.labelLoginName = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.wmsDataProvider1 = new DevExpress.XtraMap.WmsDataProvider();
            this.imageLayer2 = new DevExpress.XtraMap.ImageLayer();
            this.heatmapProvider1 = new DevExpress.XtraMap.HeatmapProvider();
            this.txtBoxAddUserTrack = new System.Windows.Forms.TextBox();
            this.lblUserTrack = new System.Windows.Forms.Label();
            this.btnAddUserTrack = new System.Windows.Forms.Button();
            this.grdUserIds = new DevExpress.XtraGrid.GridControl();
            this.gridViewUserIDs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.UserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnZoom = new System.Windows.Forms.Button();
            this.buttonSetStandort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUserIds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUserIDs)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLoginName
            // 
            this.labelLoginName.AutoSize = true;
            this.labelLoginName.Location = new System.Drawing.Point(12, 9);
            this.labelLoginName.Name = "labelLoginName";
            this.labelLoginName.Size = new System.Drawing.Size(123, 20);
            this.labelLoginName.TabIndex = 0;
            this.labelLoginName.Text = "Angemeldet als:";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(17, 912);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(112, 35);
            this.buttonLogout.TabIndex = 12;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // mapControl1
            // 
            this.mapControl1.CenterPoint = new DevExpress.XtraMap.GeoPoint(50.5D, 10D);
            this.mapControl1.Layers.Add(this.imageLayer1);
            this.mapControl1.Layers.Add(this.imageLayer2);
            this.mapControl1.Location = new System.Drawing.Point(840, -6);
            this.mapControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(1188, 912);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.ZoomLevel = 5.8D;
            this.imageLayer1.DataProvider = this.wmsDataProvider1;
            this.imageLayer1.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            this.imageLayer1.Name = "WmsMap";
            this.wmsDataProvider1.ActiveLayerName = "OSM-WMS";
            this.wmsDataProvider1.ServerUri = "http://ows.mundialis.de/services/service?";
            this.imageLayer2.DataProvider = this.heatmapProvider1;
            // 
            // txtBoxAddUserTrack
            // 
            this.txtBoxAddUserTrack.Location = new System.Drawing.Point(136, 46);
            this.txtBoxAddUserTrack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxAddUserTrack.Name = "txtBoxAddUserTrack";
            this.txtBoxAddUserTrack.Size = new System.Drawing.Size(453, 26);
            this.txtBoxAddUserTrack.TabIndex = 13;
            // 
            // lblUserTrack
            // 
            this.lblUserTrack.AutoSize = true;
            this.lblUserTrack.Location = new System.Drawing.Point(14, 50);
            this.lblUserTrack.Name = "lblUserTrack";
            this.lblUserTrack.Size = new System.Drawing.Size(86, 20);
            this.lblUserTrack.TabIndex = 14;
            this.lblUserTrack.Text = "User Track";
            // 
            // btnAddUserTrack
            // 
            this.btnAddUserTrack.Location = new System.Drawing.Point(596, 46);
            this.btnAddUserTrack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddUserTrack.Name = "btnAddUserTrack";
            this.btnAddUserTrack.Size = new System.Drawing.Size(84, 29);
            this.btnAddUserTrack.TabIndex = 15;
            this.btnAddUserTrack.Text = "Track";
            this.btnAddUserTrack.UseVisualStyleBackColor = true;
            this.btnAddUserTrack.Click += new System.EventHandler(this.btnAddUserTrack_Click);
            // 
            // grdUserIds
            // 
            this.grdUserIds.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grdUserIds.Location = new System.Drawing.Point(18, 85);
            this.grdUserIds.MainView = this.gridViewUserIDs;
            this.grdUserIds.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grdUserIds.Name = "grdUserIds";
            this.grdUserIds.Size = new System.Drawing.Size(822, 1461);
            this.grdUserIds.TabIndex = 16;
            this.grdUserIds.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUserIDs});
            // 
            // gridViewUserIDs
            // 
            this.gridViewUserIDs.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.UserID});
            this.gridViewUserIDs.DetailHeight = 787;
            this.gridViewUserIDs.GridControl = this.grdUserIds;
            this.gridViewUserIDs.Name = "gridViewUserIDs";
            this.gridViewUserIDs.OptionsBehavior.ReadOnly = true;
            this.gridViewUserIDs.OptionsEditForm.PopupEditFormWidth = 1800;
            // 
            // UserID
            // 
            this.UserID.Caption = "UserID";
            this.UserID.FieldName = "UserID";
            this.UserID.MinWidth = 55;
            this.UserID.Name = "UserID";
            this.UserID.Visible = true;
            this.UserID.VisibleIndex = 0;
            this.UserID.Width = 211;
            // 
            // btnZoom
            // 
            this.btnZoom.Location = new System.Drawing.Point(748, 46);
            this.btnZoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(84, 29);
            this.btnZoom.TabIndex = 17;
            this.btnZoom.Text = "Zoom";
            this.btnZoom.UseVisualStyleBackColor = true;
            this.btnZoom.Click += new System.EventHandler(this.btnZoom_Click);
            // 
            // buttonSetStandort
            // 
            this.buttonSetStandort.Location = new System.Drawing.Point(687, 9);
            this.buttonSetStandort.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonSetStandort.Name = "buttonSetStandort";
            this.buttonSetStandort.Size = new System.Drawing.Size(145, 29);
            this.buttonSetStandort.TabIndex = 13;
            this.buttonSetStandort.Text = "Standort setzen";
            this.buttonSetStandort.UseVisualStyleBackColor = true;
            this.buttonSetStandort.Click += new System.EventHandler(this.buttonSetStandort_Click);
            // 
            // GetStandortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1905, 1014);
            this.Controls.Add(this.btnZoom);
            this.Controls.Add(this.grdUserIds);
            this.Controls.Add(this.btnAddUserTrack);
            this.Controls.Add(this.lblUserTrack);
            this.Controls.Add(this.txtBoxAddUserTrack);
            this.Controls.Add(this.mapControl1);
            this.Controls.Add(this.buttonSetStandort);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.labelLoginName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GetStandortForm";
            this.Text = "Übersicht - FAP";
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUserIds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUserIDs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLoginName;
        private System.Windows.Forms.Button buttonLogout;
        private DevExpress.XtraMap.MapControl mapControl1;
        private DevExpress.XtraMap.ImageLayer imageLayer1;
        private DevExpress.XtraMap.WmsDataProvider wmsDataProvider1;
        private DevExpress.XtraMap.ImageLayer imageLayer2;
        private DevExpress.XtraMap.HeatmapProvider heatmapProvider1;
        private System.Windows.Forms.TextBox txtBoxAddUserTrack;
        private System.Windows.Forms.Label lblUserTrack;
        private System.Windows.Forms.Button btnAddUserTrack;
        private DevExpress.XtraGrid.GridControl grdUserIds;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUserIDs;
        private DevExpress.XtraGrid.Columns.GridColumn clmUserID;
        private DevExpress.XtraGrid.Columns.GridColumn UserID;
        private System.Windows.Forms.Button btnZoom;
        private System.Windows.Forms.Button buttonSetStandort;
    }
}