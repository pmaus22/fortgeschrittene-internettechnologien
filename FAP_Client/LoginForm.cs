using FAP_Client.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FAP_Client
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            // Open registration window
            RegisterForm registerForm = new RegisterForm();
            DialogResult dialogResult = registerForm.ShowDialog();
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            // Create new object with login data
            var loginBody = new LoginBody
            {
                loginName = textBoxLoginName.Text,
                passwort = new Passwort
                {
                    passwort = textBoxPasswort.Text
                }
            };

            // Send login request to server
            var loginResponse = await Program.LoginAsync(loginBody);

            // Save session ID and go to main app
            if (loginResponse.sessionID != null)
            {
                // TODO: Go To Hauptseite + sessionID merken
            }

            // Show error message when login fails
            else
            {
                labelMessage.Text = "Fehler: Falsche Anmeldedaten";
            }
        }
    }
}
