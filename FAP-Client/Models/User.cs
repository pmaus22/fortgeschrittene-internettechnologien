namespace FAP_Client.Models
{
    public class User
    {
        public string LoginName { get; set; }
        
        public Passwort Passwort { get; set; }

        public string Vorname { get; set; }
    
        public string Nachname { get; set; }

        public string Strasse { get; set; }

        public string Plz { get; set; }

        public string Ort { get; set; }

        public string Land { get; set; }

        public string Telefon { get; set; }

        public Email Email { get; set; }

    }
}
