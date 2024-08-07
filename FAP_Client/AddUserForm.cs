﻿using FAP_Client.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FAP_Client
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private async void textBoxPlz_TextChanged(object sender, EventArgs e)
        {
            // Check if the entered text is a postal code.
            if (textBoxPlz.Text.Length == 5 && textBoxPlz.Text.All(char.IsDigit))
            {
                // Send request to server to get the corresponding place.
                var getOrtResponse = await ApiController.GetOrtAsync(textBoxPlz.Text, "pmaus22");

                // Fill place name automatically when the server responds successfully.
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
            // Check if there ist any text.
            if (textBoxLoginName.Text.Length == 0)
            {
                labelCheckLoginName.Text = "";
            }

            // Check if the entered text is an available login name.
            else
            {
                // Send request to server to check login name.
                var boolResponse = await ApiController.CheckLoginNameAsync(textBoxLoginName.Text);

                // Say that login name is available.
                if (boolResponse.ergebnis)
                {
                    labelCheckLoginName.ForeColor = Color.Green;
                    labelCheckLoginName.Text = "✅ Nutzername verfügbar";
                }

                // Say that login name is unavailable.
                else
                {
                    labelCheckLoginName.ForeColor = Color.Red;
                    labelCheckLoginName.Text = "❌ Nutzername nicht verfügbar";
                }
            }
        }

        private async void buttonOk_Click(object sender, EventArgs e)
        {
            // Check if password was entered correctly.
            if (textBoxPasswort.Text == textBoxPasswortWiederholen.Text)
            {
                // Create user object with given attributes.
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

                // Send request to the server to add new user.
                var addUserResponse = await ApiController.AddUserAsync(user);

                // Close window after successful user registration.
                if (addUserResponse.ergebnis)
                {
                    this.Dispose();
                }

                // Show error message from the server response.
                else
                {
                    labelMessage.Text = "⚠️ " + addUserResponse.meldung.ToString();
                }
            }

            // Show error message when password was entered incorrectly.
            else
            {
                labelMessage.Text = "⚠️ Passwörter stimmen nicht überein";
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // Close window.
            this.Dispose();
        }
    }
}
