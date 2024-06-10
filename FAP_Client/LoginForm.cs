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
            RegisterForm registerForm = new RegisterForm();
            DialogResult dialogResult = registerForm.ShowDialog();
        }
    }
}
