namespace FAP_Client
{
    partial class SetStandortForm
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
            this.labelLoginName = new System.Windows.Forms.Label();
            this.textBoxPlz = new System.Windows.Forms.TextBox();
            this.labelLand = new System.Windows.Forms.Label();
            this.textBoxLand = new System.Windows.Forms.TextBox();
            this.labelStrasse = new System.Windows.Forms.Label();
            this.textBoxStrasse = new System.Windows.Forms.TextBox();
            this.labelOrt = new System.Windows.Forms.Label();
            this.textBoxOrt = new System.Windows.Forms.TextBox();
            this.labelPlz = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLoginName
            // 
            this.labelLoginName.AutoSize = true;
            this.labelLoginName.Location = new System.Drawing.Point(12, 9);
            this.labelLoginName.Name = "labelLoginName";
            this.labelLoginName.Size = new System.Drawing.Size(100, 20);
            this.labelLoginName.TabIndex = 0;
            this.labelLoginName.Text = "Nutzername:";
            // 
            // textBoxPlz
            // 
            this.textBoxPlz.Location = new System.Drawing.Point(81, 36);
            this.textBoxPlz.Name = "textBoxPlz";
            this.textBoxPlz.Size = new System.Drawing.Size(148, 26);
            this.textBoxPlz.TabIndex = 47;
            this.textBoxPlz.TextChanged += new System.EventHandler(this.textBoxPlz_TextChanged);
            // 
            // labelLand
            // 
            this.labelLand.AutoSize = true;
            this.labelLand.Location = new System.Drawing.Point(13, 147);
            this.labelLand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLand.Name = "labelLand";
            this.labelLand.Size = new System.Drawing.Size(45, 20);
            this.labelLand.TabIndex = 54;
            this.labelLand.Text = "Land";
            // 
            // textBoxLand
            // 
            this.textBoxLand.Location = new System.Drawing.Point(81, 144);
            this.textBoxLand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLand.Name = "textBoxLand";
            this.textBoxLand.Size = new System.Drawing.Size(148, 26);
            this.textBoxLand.TabIndex = 50;
            // 
            // labelStrasse
            // 
            this.labelStrasse.AutoSize = true;
            this.labelStrasse.Location = new System.Drawing.Point(13, 111);
            this.labelStrasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStrasse.Name = "labelStrasse";
            this.labelStrasse.Size = new System.Drawing.Size(58, 20);
            this.labelStrasse.TabIndex = 53;
            this.labelStrasse.Text = "Straße";
            // 
            // textBoxStrasse
            // 
            this.textBoxStrasse.Location = new System.Drawing.Point(81, 108);
            this.textBoxStrasse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxStrasse.Name = "textBoxStrasse";
            this.textBoxStrasse.Size = new System.Drawing.Size(148, 26);
            this.textBoxStrasse.TabIndex = 49;
            // 
            // labelOrt
            // 
            this.labelOrt.AutoSize = true;
            this.labelOrt.Location = new System.Drawing.Point(14, 74);
            this.labelOrt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrt.Name = "labelOrt";
            this.labelOrt.Size = new System.Drawing.Size(31, 20);
            this.labelOrt.TabIndex = 52;
            this.labelOrt.Text = "Ort";
            // 
            // textBoxOrt
            // 
            this.textBoxOrt.Location = new System.Drawing.Point(81, 72);
            this.textBoxOrt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxOrt.Name = "textBoxOrt";
            this.textBoxOrt.Size = new System.Drawing.Size(148, 26);
            this.textBoxOrt.TabIndex = 48;
            // 
            // labelPlz
            // 
            this.labelPlz.AutoSize = true;
            this.labelPlz.Location = new System.Drawing.Point(13, 39);
            this.labelPlz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlz.Name = "labelPlz";
            this.labelPlz.Size = new System.Drawing.Size(38, 20);
            this.labelPlz.TabIndex = 51;
            this.labelPlz.Text = "PLZ";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(134, 194);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 35);
            this.buttonCancel.TabIndex = 56;
            this.buttonCancel.Text = "Abbrechen";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(13, 194);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(112, 35);
            this.buttonOk.TabIndex = 55;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(14, 234);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 20);
            this.labelMessage.TabIndex = 80;
            // 
            // SetStandortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxPlz);
            this.Controls.Add(this.labelLand);
            this.Controls.Add(this.textBoxLand);
            this.Controls.Add(this.labelStrasse);
            this.Controls.Add(this.textBoxStrasse);
            this.Controls.Add(this.labelOrt);
            this.Controls.Add(this.textBoxOrt);
            this.Controls.Add(this.labelPlz);
            this.Controls.Add(this.labelLoginName);
            this.Name = "SetStandortForm";
            this.Text = "SetStandortForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLoginName;
        private System.Windows.Forms.TextBox textBoxPlz;
        private System.Windows.Forms.Label labelLand;
        private System.Windows.Forms.TextBox textBoxLand;
        private System.Windows.Forms.Label labelStrasse;
        private System.Windows.Forms.TextBox textBoxStrasse;
        private System.Windows.Forms.Label labelOrt;
        private System.Windows.Forms.TextBox textBoxOrt;
        private System.Windows.Forms.Label labelPlz;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelMessage;
    }
}