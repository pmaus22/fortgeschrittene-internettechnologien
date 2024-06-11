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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetStandortForm));
            this.labelHeader = new System.Windows.Forms.Label();
            this.textBoxPlz = new System.Windows.Forms.TextBox();
            this.labelLand = new System.Windows.Forms.Label();
            this.textBoxLand = new System.Windows.Forms.TextBox();
            this.labelStrasse = new System.Windows.Forms.Label();
            this.textBoxStrasse = new System.Windows.Forms.TextBox();
            this.labelOrt = new System.Windows.Forms.Label();
            this.textBoxOrt = new System.Windows.Forms.TextBox();
            this.labelPlz = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(12, 9);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(719, 48);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Bitte geben Sie Ihren aktuellen Standort an.";
            // 
            // textBoxPlz
            // 
            this.textBoxPlz.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlz.Location = new System.Drawing.Point(100, 87);
            this.textBoxPlz.Name = "textBoxPlz";
            this.textBoxPlz.Size = new System.Drawing.Size(222, 39);
            this.textBoxPlz.TabIndex = 47;
            this.textBoxPlz.TextChanged += new System.EventHandler(this.textBoxPlz_TextChanged);
            // 
            // labelLand
            // 
            this.labelLand.AutoSize = true;
            this.labelLand.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLand.Location = new System.Drawing.Point(11, 235);
            this.labelLand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLand.Name = "labelLand";
            this.labelLand.Size = new System.Drawing.Size(65, 32);
            this.labelLand.TabIndex = 54;
            this.labelLand.Text = "Land";
            // 
            // textBoxLand
            // 
            this.textBoxLand.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLand.Location = new System.Drawing.Point(100, 232);
            this.textBoxLand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLand.Name = "textBoxLand";
            this.textBoxLand.Size = new System.Drawing.Size(222, 39);
            this.textBoxLand.TabIndex = 50;
            // 
            // labelStrasse
            // 
            this.labelStrasse.AutoSize = true;
            this.labelStrasse.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStrasse.Location = new System.Drawing.Point(12, 186);
            this.labelStrasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStrasse.Name = "labelStrasse";
            this.labelStrasse.Size = new System.Drawing.Size(80, 32);
            this.labelStrasse.TabIndex = 53;
            this.labelStrasse.Text = "Straße";
            // 
            // textBoxStrasse
            // 
            this.textBoxStrasse.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStrasse.Location = new System.Drawing.Point(100, 183);
            this.textBoxStrasse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxStrasse.Name = "textBoxStrasse";
            this.textBoxStrasse.Size = new System.Drawing.Size(222, 39);
            this.textBoxStrasse.TabIndex = 49;
            // 
            // labelOrt
            // 
            this.labelOrt.AutoSize = true;
            this.labelOrt.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrt.Location = new System.Drawing.Point(12, 137);
            this.labelOrt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrt.Name = "labelOrt";
            this.labelOrt.Size = new System.Drawing.Size(48, 32);
            this.labelOrt.TabIndex = 52;
            this.labelOrt.Text = "Ort";
            // 
            // textBoxOrt
            // 
            this.textBoxOrt.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOrt.Location = new System.Drawing.Point(100, 134);
            this.textBoxOrt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxOrt.Name = "textBoxOrt";
            this.textBoxOrt.Size = new System.Drawing.Size(222, 39);
            this.textBoxOrt.TabIndex = 48;
            // 
            // labelPlz
            // 
            this.labelPlz.AutoSize = true;
            this.labelPlz.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlz.Location = new System.Drawing.Point(12, 90);
            this.labelPlz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlz.Name = "labelPlz";
            this.labelPlz.Size = new System.Drawing.Size(53, 32);
            this.labelPlz.TabIndex = 51;
            this.labelPlz.Text = "PLZ";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.Color.Red;
            this.labelMessage.Location = new System.Drawing.Point(12, 389);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 32);
            this.labelMessage.TabIndex = 83;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(227, 331);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(201, 53);
            this.buttonCancel.TabIndex = 82;
            this.buttonCancel.Text = "Abbrechen";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.Transparent;
            this.buttonOk.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.Location = new System.Drawing.Point(18, 331);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(201, 53);
            this.buttonOk.TabIndex = 81;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // SetStandortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 441);
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
            this.Controls.Add(this.labelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SetStandortForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Standort setzen - FAP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.TextBox textBoxPlz;
        private System.Windows.Forms.Label labelLand;
        private System.Windows.Forms.TextBox textBoxLand;
        private System.Windows.Forms.Label labelStrasse;
        private System.Windows.Forms.TextBox textBoxStrasse;
        private System.Windows.Forms.Label labelOrt;
        private System.Windows.Forms.TextBox textBoxOrt;
        private System.Windows.Forms.Label labelPlz;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
    }
}