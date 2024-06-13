using FAP_Client.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FAP_Client
{
    public partial class SetStandortForm : Form
    {
        // Variables to save login name and session ID of logged in user
        public static string CurrentLoginName;
        public static string CurrentSessionID;

        public SetStandortForm()
        {
            InitializeComponent();
            labelHeader.Text = "Bitte geben Sie Ihren aktuellen Standort an, " + CurrentLoginName + ".";
        }

        private async void textBoxPlz_TextChanged(object sender, EventArgs e)
        {
            // Check if the entered text is a postal code
            if (textBoxPlz.Text.Length == 5 && textBoxPlz.Text.All(char.IsDigit))
            {
                // Send request to server to get the corresponding place (using the geonames.org username)
                var getOrtResponse = await ApiController.GetOrtAsync(textBoxPlz.Text, "pmaus22");

                // Fill place name automatically when the server responds successfully
                try
                {
                    textBoxOrt.Text = getOrtResponse.postalCodes[0].placeName;
                }
                catch
                {
                }
            }
        }

        private async void buttonOk_Click(object sender, EventArgs e)
        {
            // Send request to server to get latidude and longitude from entered address
            var standort = await ApiController.GetStandortPerAdresseAsync(textBoxLand.Text, textBoxPlz.Text, textBoxOrt.Text, textBoxStrasse.Text);
                
            if (standort != null)
            {
                // Create new object with user data and location
                var setStandortBody = new SetStandortBody
                {
                    loginName = CurrentLoginName,
                    sitzung = CurrentSessionID,
                    standort = standort
                };

                // Send request to server to set new user location using the obtained latitude and longitude values
                var boolResponse = await ApiController.SetStandortAsync(setStandortBody);

                // Refresh location list and close window when location was set sucessfully
                if (boolResponse.ergebnis)
                {
                    GetStandortForm.RefreshLocationList();
                    this.Dispose();
                }

                // Show error message when server indicates failure
                else
                {
                    labelMessage.Text = "⚠️ Standort konnte nicht gesetzt werden";
                }
            }
            else
            {
                // Show error message when server does not respond with latitude and longitude
                labelMessage.Text = "⚠️ Falsche Adressangaben";
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // Close window
            this.Dispose();
        }
    }
}
