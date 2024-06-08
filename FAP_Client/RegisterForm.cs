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

        private async void textBoxPlz_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPlz.Text.Length == 5 && textBoxPlz.Text.All(char.IsDigit))
            {
                var getOrtResponse = await Program.GetOrtAsync(textBoxPlz.Text, "pmaus22");
                try
                {
                    textBoxOrt.Text = getOrtResponse.postalCodes[0].placeName;
                }
                catch
                {
                }
            }
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

        private async void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxPasswort.Text == textBoxPasswortWiederholen.Text)
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
                    // TODO: Go To Anmeldeseite
                }
                else
                {
                    labelMessage.Text = "Fehler: " + addUserResponse.meldung.ToString();
                }
            }
            else
            {
                labelMessage.Text = "Fehler: Passwörter stimmen nicht überein";
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // TODO: Go To Anmeldeseite
        }
    }
}
