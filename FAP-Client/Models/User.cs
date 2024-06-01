namespace FAP_Client.Models
{
    public class User
    {
        public string loginName { get; set; }
        
        public Passwort passwort { get; set; }

        public string vorname { get; set; }
    
        public string nachname { get; set; }

        public string strasse { get; set; }

        public string plz { get; set; }

        public string ort { get; set; }

        public string land { get; set; }

        public string telefon { get; set; }

        public Email email { get; set; }

    }
}
