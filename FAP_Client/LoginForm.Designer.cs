namespace FAP_Client
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelPasswort = new System.Windows.Forms.Label();
            this.textBoxPasswort = new System.Windows.Forms.TextBox();
            this.labelLoginName = new System.Windows.Forms.Label();
            this.textBoxLoginName = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelRegister = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.Color.Red;
            this.labelMessage.Location = new System.Drawing.Point(231, 342);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 48);
            this.labelMessage.TabIndex = 79;
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.Transparent;
            this.buttonRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonRegister.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.Location = new System.Drawing.Point(23, 454);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(201, 53);
            this.buttonRegister.TabIndex = 78;
            this.buttonRegister.Text = "Registrieren";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLogin.Location = new System.Drawing.Point(23, 332);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(201, 53);
            this.buttonLogin.TabIndex = 77;
            this.buttonLogin.Text = "Anmelden";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelPasswort
            // 
            this.labelPasswort.AutoSize = true;
            this.labelPasswort.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswort.Location = new System.Drawing.Point(17, 274);
            this.labelPasswort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPasswort.Name = "labelPasswort";
            this.labelPasswort.Size = new System.Drawing.Size(105, 32);
            this.labelPasswort.TabIndex = 64;
            this.labelPasswort.Text = "Passwort";
            // 
            // textBoxPasswort
            // 
            this.textBoxPasswort.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswort.Location = new System.Drawing.Point(171, 274);
            this.textBoxPasswort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPasswort.Name = "textBoxPasswort";
            this.textBoxPasswort.PasswordChar = '*';
            this.textBoxPasswort.Size = new System.Drawing.Size(333, 39);
            this.textBoxPasswort.TabIndex = 63;
            // 
            // labelLoginName
            // 
            this.labelLoginName.AutoSize = true;
            this.labelLoginName.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginName.Location = new System.Drawing.Point(17, 225);
            this.labelLoginName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoginName.Name = "labelLoginName";
            this.labelLoginName.Size = new System.Drawing.Size(146, 32);
            this.labelLoginName.TabIndex = 62;
            this.labelLoginName.Text = "Nutzername";
            // 
            // textBoxLoginName
            // 
            this.textBoxLoginName.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLoginName.Location = new System.Drawing.Point(171, 225);
            this.textBoxLoginName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLoginName.Name = "textBoxLoginName";
            this.textBoxLoginName.Size = new System.Drawing.Size(333, 39);
            this.textBoxLoginName.TabIndex = 61;
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(17, 96);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(781, 101);
            this.labelDescription.TabIndex = 80;
            this.labelDescription.Text = "Herzlich willkommen bei FRIENDS AND PLACES, Ihrem Desktop-Client, der Ihnen jeder" +
    "zeit einen Überblick gibt, wo sich Ihre Freunde gerade herumtreiben.";
            // 
            // labelRegister
            // 
            this.labelRegister.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegister.Location = new System.Drawing.Point(22, 412);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(781, 37);
            this.labelRegister.TabIndex = 81;
            this.labelRegister.Text = "Wenn Sie zum ersten Mal hier sind, registrieren Sie sich bitte zunächst.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 64);
            this.label1.TabIndex = 82;
            this.label1.Text = "FAP Desktop-Client";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 521);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelRegister);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelPasswort);
            this.Controls.Add(this.textBoxPasswort);
            this.Controls.Add(this.labelLoginName);
            this.Controls.Add(this.textBoxLoginName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Anmeldung - FAP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelPasswort;
        private System.Windows.Forms.TextBox textBoxPasswort;
        private System.Windows.Forms.Label labelLoginName;
        private System.Windows.Forms.TextBox textBoxLoginName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.Label label1;
    }
}