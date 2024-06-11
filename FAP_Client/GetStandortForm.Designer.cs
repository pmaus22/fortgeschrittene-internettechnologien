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
            this.mapControl = new DevExpress.XtraMap.MapControl();
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.wmsDataProvider1 = new DevExpress.XtraMap.WmsDataProvider();
            this.imageLayer2 = new DevExpress.XtraMap.ImageLayer();
            this.heatmapProvider1 = new DevExpress.XtraMap.HeatmapProvider();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.labelUserId = new System.Windows.Forms.Label();
            this.buttonGetUser = new System.Windows.Forms.Button();
            this.buttonZoom = new System.Windows.Forms.Button();
            this.buttonSetStandort = new System.Windows.Forms.Button();
            this.labelMessageGetUser = new System.Windows.Forms.Label();
            this.listBoxUserList = new System.Windows.Forms.ListBox();
            this.labelMessageZoom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).BeginInit();
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
            this.buttonLogout.TabIndex = 6;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // mapControl
            // 
            this.mapControl.CenterPoint = new DevExpress.XtraMap.GeoPoint(50.5D, 10D);
            this.mapControl.Layers.Add(this.imageLayer1);
            this.mapControl.Layers.Add(this.imageLayer2);
            this.mapControl.Location = new System.Drawing.Point(838, 15);
            this.mapControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mapControl.Name = "mapControl";
            this.mapControl.Size = new System.Drawing.Size(1047, 995);
            this.mapControl.TabIndex = 5;
            this.mapControl.ZoomLevel = 5.8D;
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
            this.textBoxUserId.TabIndex = 1;
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
            this.buttonGetUser.TabIndex = 2;
            this.buttonGetUser.Text = "Hinzufügen";
            this.buttonGetUser.UseVisualStyleBackColor = false;
            this.buttonGetUser.Click += new System.EventHandler(this.buttonGetUser_Click);
            // 
            // buttonZoom
            // 
            this.buttonZoom.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZoom.Location = new System.Drawing.Point(628, 237);
            this.buttonZoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonZoom.Name = "buttonZoom";
            this.buttonZoom.Size = new System.Drawing.Size(202, 53);
            this.buttonZoom.TabIndex = 4;
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
            this.buttonSetStandort.TabIndex = 0;
            this.buttonSetStandort.Text = "Standort setzen";
            this.buttonSetStandort.UseVisualStyleBackColor = false;
            this.buttonSetStandort.Click += new System.EventHandler(this.buttonSetStandort_Click);
            // 
            // labelMessageGetUser
            // 
            this.labelMessageGetUser.AutoSize = true;
            this.labelMessageGetUser.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessageGetUser.ForeColor = System.Drawing.Color.Red;
            this.labelMessageGetUser.Location = new System.Drawing.Point(12, 181);
            this.labelMessageGetUser.Name = "labelMessageGetUser";
            this.labelMessageGetUser.Size = new System.Drawing.Size(0, 32);
            this.labelMessageGetUser.TabIndex = 18;
            // 
            // listBoxUserList
            // 
            this.listBoxUserList.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxUserList.FormattingEnabled = true;
            this.listBoxUserList.ItemHeight = 32;
            this.listBoxUserList.Location = new System.Drawing.Point(15, 305);
            this.listBoxUserList.Name = "listBoxUserList";
            this.listBoxUserList.Size = new System.Drawing.Size(816, 644);
            this.listBoxUserList.TabIndex = 3;
            // 
            // labelMessageZoom
            // 
            this.labelMessageZoom.AutoSize = true;
            this.labelMessageZoom.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessageZoom.ForeColor = System.Drawing.Color.Red;
            this.labelMessageZoom.Location = new System.Drawing.Point(12, 247);
            this.labelMessageZoom.Name = "labelMessageZoom";
            this.labelMessageZoom.Size = new System.Drawing.Size(0, 32);
            this.labelMessageZoom.TabIndex = 20;
            // 
            // GetStandortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.labelMessageZoom);
            this.Controls.Add(this.listBoxUserList);
            this.Controls.Add(this.labelMessageGetUser);
            this.Controls.Add(this.buttonZoom);
            this.Controls.Add(this.buttonGetUser);
            this.Controls.Add(this.labelUserId);
            this.Controls.Add(this.textBoxUserId);
            this.Controls.Add(this.mapControl);
            this.Controls.Add(this.buttonSetStandort);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.labelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GetStandortForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Übersicht - FAP";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GetStandortForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button buttonLogout;
        private DevExpress.XtraMap.MapControl mapControl;
        private DevExpress.XtraMap.ImageLayer imageLayer1;
        private DevExpress.XtraMap.WmsDataProvider wmsDataProvider1;
        private DevExpress.XtraMap.ImageLayer imageLayer2;
        private DevExpress.XtraMap.HeatmapProvider heatmapProvider1;
        private System.Windows.Forms.TextBox textBoxUserId;
        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.Button buttonGetUser;
        private DevExpress.XtraGrid.Columns.GridColumn clmUserID;
        private System.Windows.Forms.Button buttonZoom;
        private System.Windows.Forms.Button buttonSetStandort;
        private System.Windows.Forms.Label labelMessageGetUser;
        private System.Windows.Forms.ListBox listBoxUserList;
        private System.Windows.Forms.Label labelMessageZoom;
    }
}