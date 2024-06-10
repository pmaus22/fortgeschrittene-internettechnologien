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
            this.buttonSetStandort = new System.Windows.Forms.Button();
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
            this.buttonLogout.Location = new System.Drawing.Point(13, 401);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(112, 35);
            this.buttonLogout.TabIndex = 12;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonSetStandort
            // 
            this.buttonSetStandort.Location = new System.Drawing.Point(133, 401);
            this.buttonSetStandort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSetStandort.Name = "buttonSetStandort";
            this.buttonSetStandort.Size = new System.Drawing.Size(143, 35);
            this.buttonSetStandort.TabIndex = 13;
            this.buttonSetStandort.Text = "Standort setzen";
            this.buttonSetStandort.UseVisualStyleBackColor = true;
            this.buttonSetStandort.Click += new System.EventHandler(this.buttonSetStandort_Click);
            // 
            // GetStandortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSetStandort);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.labelLoginName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GetStandortForm";
            this.Text = "Übersicht - FAP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLoginName;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonSetStandort;
    }
}