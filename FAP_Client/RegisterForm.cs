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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private async void buttonOk_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                loginName = textBoxLoginName.Text,
                passwort = new Passwort
                {
                    passwort = textBoxPasswort.Text
                },
                vorname = textBoxVorname.Text,
                nachname = textBoxNachname.Text,
                strasse = textBoxStrasse.Text,
                plz = textBoxPlz.Text,
                ort = textBoxOrt.Text,
                land = textBoxLand.Text,
                telefon = textBoxTelefon.Text,
                email = new Email
                {
                    adresse = textBoxEmail.Text
                }
            };
            var addUserResponse = await Program.AddUserAsync(user);
            if (addUserResponse.ergebnis)
            {

            }
            else
            {
                labelMessage.Text = "Fehler: " + addUserResponse.meldung.ToString();
            }
        }

        private void textBoxPlz_TextChanged(object sender, EventArgs e)
        {

        }

        private async void textBoxLoginName_TextChanged(object sender, EventArgs e)
        {
            var boolResponse = await Program.CheckLoginNameAsync(textBoxLoginName.Text);
            if(boolResponse.ergebnis)
            {
                checkBoxLoginName.Checked = true;
                checkBoxLoginName.Text = "Nutzername verfügbar";
            }
            else
            {
                checkBoxLoginName.Checked = false;
                checkBoxLoginName.Text = "Nutzername nicht verfügbar";
            }
        }

        private void textBoxPasswortWiederholen_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPasswort.Text == textBoxPasswortWiederholen.Text)
            {
                checkBoxPasswort.Checked = true;
                checkBoxPasswort.Text = "Passwörter stimmen überein";
            }
            else
            {
                checkBoxPasswort.Checked = false;
                checkBoxPasswort.Text = "Passwörter stimmen nicht überein";
            }
        }
    }
}
