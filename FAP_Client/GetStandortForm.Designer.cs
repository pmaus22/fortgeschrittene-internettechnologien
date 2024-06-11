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
            this.labelHeader = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.wmsDataProvider1 = new DevExpress.XtraMap.WmsDataProvider();
            this.imageLayer2 = new DevExpress.XtraMap.ImageLayer();
            this.heatmapProvider1 = new DevExpress.XtraMap.HeatmapProvider();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.labelUserId = new System.Windows.Forms.Label();
            this.buttonGetUser = new System.Windows.Forms.Button();
            this.grdUserIds = new DevExpress.XtraGrid.GridControl();
            this.gridViewUserIDs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.UserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.buttonZoom = new System.Windows.Forms.Button();
            this.buttonSetStandort = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUserIds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUserIDs)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(12, 15);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(244, 32);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Herzlich willkommen!";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(13, 957);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(201, 53);
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
            this.mapControl1.Location = new System.Drawing.Point(838, 15);
            this.mapControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(1047, 995);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.ZoomLevel = 5.8D;
            this.imageLayer1.DataProvider = this.wmsDataProvider1;
            this.imageLayer1.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            this.imageLayer1.Name = "WmsMap";
            this.wmsDataProvider1.ActiveLayerName = "OSM-WMS";
            this.wmsDataProvider1.ServerUri = "http://ows.mundialis.de/services/service?";
            this.imageLayer2.DataProvider = this.heatmapProvider1;
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserId.Location = new System.Drawing.Point(164, 131);
            this.textBoxUserId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.Size = new System.Drawing.Size(458, 39);
            this.textBoxUserId.TabIndex = 13;
            // 
            // labelUserId
            // 
            this.labelUserId.AutoSize = true;
            this.labelUserId.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserId.Location = new System.Drawing.Point(12, 134);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(146, 32);
            this.labelUserId.TabIndex = 14;
            this.labelUserId.Text = "Nutzername";
            // 
            // buttonGetUser
            // 
            this.buttonGetUser.BackColor = System.Drawing.Color.Transparent;
            this.buttonGetUser.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetUser.Location = new System.Drawing.Point(628, 124);
            this.buttonGetUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonGetUser.Name = "buttonGetUser";
            this.buttonGetUser.Size = new System.Drawing.Size(201, 53);
            this.buttonGetUser.TabIndex = 15;
            this.buttonGetUser.Text = "Hinzufügen";
            this.buttonGetUser.UseVisualStyleBackColor = false;
            this.buttonGetUser.Click += new System.EventHandler(this.buttonGetUser_Click);
            // 
            // grdUserIds
            // 
            this.grdUserIds.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(48, 48, 48, 48);
            this.grdUserIds.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdUserIds.Location = new System.Drawing.Point(13, 300);
            this.grdUserIds.MainView = this.gridViewUserIDs;
            this.grdUserIds.Margin = new System.Windows.Forms.Padding(48, 48, 48, 48);
            this.grdUserIds.Name = "grdUserIds";
            this.grdUserIds.Size = new System.Drawing.Size(816, 643);
            this.grdUserIds.TabIndex = 16;
            this.grdUserIds.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUserIDs});
            // 
            // gridViewUserIDs
            // 
            this.gridViewUserIDs.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.UserID});
            this.gridViewUserIDs.DetailHeight = 5973;
            this.gridViewUserIDs.GridControl = this.grdUserIds;
            this.gridViewUserIDs.Name = "gridViewUserIDs";
            this.gridViewUserIDs.OptionsBehavior.ReadOnly = true;
            this.gridViewUserIDs.OptionsEditForm.PopupEditFormWidth = 13668;
            // 
            // UserID
            // 
            this.UserID.Caption = "UserID";
            this.UserID.FieldName = "UserID";
            this.UserID.MinWidth = 414;
            this.UserID.Name = "UserID";
            this.UserID.Visible = true;
            this.UserID.VisibleIndex = 0;
            this.UserID.Width = 1599;
            // 
            // buttonZoom
            // 
            this.buttonZoom.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZoom.Location = new System.Drawing.Point(628, 237);
            this.buttonZoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonZoom.Name = "buttonZoom";
            this.buttonZoom.Size = new System.Drawing.Size(202, 53);
            this.buttonZoom.TabIndex = 17;
            this.buttonZoom.Text = "Zoom";
            this.buttonZoom.UseVisualStyleBackColor = true;
            this.buttonZoom.Click += new System.EventHandler(this.buttonZoom_Click);
            // 
            // buttonSetStandort
            // 
            this.buttonSetStandort.BackColor = System.Drawing.Color.Transparent;
            this.buttonSetStandort.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetStandort.Location = new System.Drawing.Point(628, 15);
            this.buttonSetStandort.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonSetStandort.Name = "buttonSetStandort";
            this.buttonSetStandort.Size = new System.Drawing.Size(201, 53);
            this.buttonSetStandort.TabIndex = 13;
            this.buttonSetStandort.Text = "Standort setzen";
            this.buttonSetStandort.UseVisualStyleBackColor = false;
            this.buttonSetStandort.Click += new System.EventHandler(this.buttonSetStandort_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.Color.Red;
            this.labelMessage.Location = new System.Drawing.Point(12, 181);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 48);
            this.labelMessage.TabIndex = 18;
            // 
            // GetStandortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonZoom);
            this.Controls.Add(this.grdUserIds);
            this.Controls.Add(this.buttonGetUser);
            this.Controls.Add(this.labelUserId);
            this.Controls.Add(this.textBoxUserId);
            this.Controls.Add(this.mapControl1);
            this.Controls.Add(this.buttonSetStandort);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.labelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GetStandortForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Übersicht - FAP";
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdUserIds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUserIDs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button buttonLogout;
        private DevExpress.XtraMap.MapControl mapControl1;
        private DevExpress.XtraMap.ImageLayer imageLayer1;
        private DevExpress.XtraMap.WmsDataProvider wmsDataProvider1;
        private DevExpress.XtraMap.ImageLayer imageLayer2;
        private DevExpress.XtraMap.HeatmapProvider heatmapProvider1;
        private System.Windows.Forms.TextBox textBoxUserId;
        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.Button buttonGetUser;
        private DevExpress.XtraGrid.GridControl grdUserIds;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUserIDs;
        private DevExpress.XtraGrid.Columns.GridColumn clmUserID;
        private DevExpress.XtraGrid.Columns.GridColumn UserID;
        private System.Windows.Forms.Button buttonZoom;
        private System.Windows.Forms.Button buttonSetStandort;
        private System.Windows.Forms.Label labelMessage;
    }
}