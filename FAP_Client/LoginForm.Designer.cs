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
            this.labelMessage.Location = new System.Drawing.Point(9, 255);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 20);
            this.labelMessage.TabIndex = 79;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(7, 404);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(112, 35);
            this.buttonRegister.TabIndex = 78;
            this.buttonRegister.Text = "Registrieren";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(9, 220);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(112, 35);
            this.buttonLogin.TabIndex = 77;
            this.buttonLogin.Text = "Anmelden";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelPasswort
            // 
            this.labelPasswort.AutoSize = true;
            this.labelPasswort.Location = new System.Drawing.Point(9, 187);
            this.labelPasswort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPasswort.Name = "labelPasswort";
            this.labelPasswort.Size = new System.Drawing.Size(74, 20);
            this.labelPasswort.TabIndex = 64;
            this.labelPasswort.Text = "Passwort";
            // 
            // textBoxPasswort
            // 
            this.textBoxPasswort.Location = new System.Drawing.Point(113, 184);
            this.textBoxPasswort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPasswort.Name = "textBoxPasswort";
            this.textBoxPasswort.PasswordChar = '*';
            this.textBoxPasswort.Size = new System.Drawing.Size(148, 26);
            this.textBoxPasswort.TabIndex = 63;
            // 
            // labelLoginName
            // 
            this.labelLoginName.AutoSize = true;
            this.labelLoginName.Location = new System.Drawing.Point(9, 152);
            this.labelLoginName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoginName.Name = "labelLoginName";
            this.labelLoginName.Size = new System.Drawing.Size(96, 20);
            this.labelLoginName.TabIndex = 62;
            this.labelLoginName.Text = "Nutzername";
            // 
            // textBoxLoginName
            // 
            this.textBoxLoginName.Location = new System.Drawing.Point(113, 149);
            this.textBoxLoginName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLoginName.Name = "textBoxLoginName";
            this.textBoxLoginName.Size = new System.Drawing.Size(148, 26);
            this.textBoxLoginName.TabIndex = 61;
            // 
            // labelDescription
            // 
            this.labelDescription.Location = new System.Drawing.Point(12, 73);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(776, 42);
            this.labelDescription.TabIndex = 80;
            this.labelDescription.Text = "Herzlich willkommen bei FRIENDS AND PLACES, Ihrem Desktop-Client, der Ihnen jeder" +
    "zeit einen Überblick gibt, wo sich Ihre Freunde gerade herumtreiben.";
            // 
            // labelRegister
            // 
            this.labelRegister.Location = new System.Drawing.Point(6, 377);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(565, 22);
            this.labelRegister.TabIndex = 81;
            this.labelRegister.Text = "Wenn Sie zum ersten Mal hier sind, registrieren Sie sich bitte zunächst.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 55);
            this.label1.TabIndex = 82;
            this.label1.Text = "FAP Desktop-Client";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "LoginForm";
            this.Text = "Anmeldung";
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