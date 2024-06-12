using FAP_Client.Models;
using System;
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
            AddUserForm addUser = new AddUserForm();
            addUser.Show();
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

            // Save username and session ID, close login window and open main app
            if (loginResponse.sessionID != null)
            {
                GetStandortForm.CurrentLoginName = textBoxLoginName.Text;
                GetStandortForm.CurrentSessionID = loginResponse.sessionID;
                this.Hide();
                GetStandortForm getStandort = new GetStandortForm();
                getStandort.Show();
            }

            // Show error message when login fails
            else
            {
                labelMessage.Text = "⚠️ Falsche Anmeldedaten";
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Exit app when login window is closed
            Application.Exit();
        }
    }
}
