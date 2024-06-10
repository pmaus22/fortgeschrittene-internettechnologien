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
    public partial class GetStandortForm : Form
    {
        // Variables to save login name and session ID of logged in user
        public static string CurrentLoginName;
        public static string CurrentSessionID;

        public GetStandortForm()
        {
            InitializeComponent();
            labelLoginName.Text = "Angemeldet als: " + CurrentLoginName;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            // Clear user data, close main app and open login window
            CurrentSessionID = null;
            CurrentLoginName = null;
            this.Dispose();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
