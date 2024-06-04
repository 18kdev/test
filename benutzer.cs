namespace Lernen
{
    class Benutzer
    {
        // Attribute der Klasse 'Benutzer'
        public string vorname;
        private string nachname;
        private int alter;
        private string email;
        private string passwort;,
        private string kreditkarte;
        private bool istAdmin;
        private List<Benutzer> alleBenutzer;

        // Konstruktor der Klasse 'Benutzer'
        // Wenn in der Aufgabenstellung (in Materialien) steht, dass der Konstruktor folgende Parameter haben soll: (String, String, int, String, String, String)
        // Dann muss der Konstruktor auch genau diese Parameter haben
        // Also du guckst was für Attribute in der Klasse sind und machst für jedes Attribut einen Parameter im Konstruktor
        public Benutzer(string vorname, string nachname, int alter, string email, string passwort, string kreditkarte)
        {
            this.vorname = vorname;
            this.nachname = nachname;
            this.alter = alter;
            this.email = email;
            this.passwort = passwort;
            this.kreditkarte = kreditkarte;
            this.istAdmin = false; // Setzt den Wert von istAdmin auf false
            this.alleBenutzer = new List<Benutzer>(); // Initialisiert die Liste alleBenutzer (Nicht in Parameterliste, weil es nicht von außen übergeben wird)
        }

        // Getter-Methode für den Vornamen
        // public = Methode kann von außerhalb der Klasse aufgerufen werden
        // string = Rückgabetyp der Methode
        // getVorname = Name der Methode
        public string getVorname()
        {
            return this.vorname;
        }

        // Setter-Methode für den Vornamen
        // public = Methode kann von außerhalb der Klasse aufgerufen werden
        // void = Methode gibt keinen Wert zurück
        // setVorname = Name der Methode
        // string neuerVorname = Parameter, der beim Aufruf der Methode übergeben werden muss
        public void setVorname(string neuerVorname)
        {
            this.vorname = neuerVorname;
        }

        // Getter-Methode für die E-Mail
        // public = Methode kann von außerhalb der Klasse aufgerufen werden
        // string = Rückgabetyp der Methode
        // getEmail = Name der Methode
        public string getEmail()
        {
            return this.email;
        }

        // Setter-Methode für die E-Mail
        // public = Methode kann von außerhalb der Klasse aufgerufen werden
        // void = Methode gibt keinen Wert zurück
        // setEmail = Name der Methode
        // string neueEmail = Parameter, der beim Aufruf der Methode übergeben werden muss
        public void setEmail(string neueEmail)
        {
            this.email = neueEmail;
        }

        // ... Weitere Getter- und Setter-Methoden für die anderen Attribute

        // Getter-Methode für den Admin-Status
        // public = Methode kann von außerhalb der Klasse aufgerufen werden
        // bool = Rückgabetyp der Methode
        // getIstAdmin = Name der Methode
        public bool getIstAdmin()
        {
            return this.istAdmin;
        }

        // Setter-Methode für den Admin-Status
        // public = Methode kann von außerhalb der Klasse aufgerufen werden
        // void = Methode gibt keinen Wert zurück
        // setIstAdmin = Name der Methode
        // bool istAdmin = Parameter, der beim Aufruf der Methode übergeben werden muss
        public void setIstAdmin(bool istAdmin)
        {
            this.istAdmin = istAdmin;
        }

        // Statische Methode, um alle Admins zu finden
        // public = Methode kann von außerhalb der Klasse aufgerufen werden
        // static = Methode gehört zur Klasse und nicht zu einer Instanz der Klasse (Man kann es aufrufen, ohne ein Objekt der Klasse zu erstellen mit new Benutzer())
        // Benutzer = Rückgabetyp der Methode
        // getAlleAdmins = Name der Methode
        //
        // Für FOS Abschlussprüfung:
        // Du musst mit foreach arbeiten wenn was gesucht wird, weil es eine Liste ist.

        public static Benutzer getAlleAdmins()
        {
            foreach (Benutzer aktuellerBenutzer in alleBenutzer)
            {
                if (aktuellerBenutzer.getIstAdmin() == true) // Es ist entweder true oder false, also ein bool
                {
                    return aktuellerBenutzer; // Rückgabe des gefundenen Benutzers
                }
            }

            return new Benutzer("", "", 0, "", "", ""); // Rückgabe eines leeren Benutzers, wenn kein Admin gefunden wird
        }

        // Statische Methode, um einen Benutzer anhand der E-Mail zu finden
        // public = Methode kann von außerhalb der Klasse aufgerufen werden
        // static = Methode gehört zur Klasse und nicht zu einer Instanz der Klasse (Man kann es aufrufen, ohne ein Objekt der Klasse zu erstellen mit new Benutzer())
        // Benutzer = Rückgabetyp der Methode
        // getBenutzer = Name der Methode
        // string gesuchteEmail = Parameter, der beim Aufruf der Methode übergeben werden muss
        //
        // Für FOS Abschlussprüfung:
        // Du musst mit foreach arbeiten wenn was gesucht wird, weil es eine Liste ist.
        // Beispielsweise, du gehst durch alle Benutzer und suchst nach einem Benutzer mit einer bestimmten E-Mail der von außen übergeben (als Parameter) wird.
        public static Benutzer getBenutzer(string gesuchteEmail)
        {
            foreach (Benutzer aktuellerBenutzer in alleBenutzer)
            {
                if (aktuellerBenutzer.getEmail() == gesuchteEmail)
                {
                    return aktuellerBenutzer; // Rückgabe des gefundenen Benutzers
                }
            }

            return new Benutzer("", "", 0, "", "", ""); // Rückgabe eines leeren Benutzers, wenn keiner gefunden wird
        }
    }

    // Hauptprogramm, wo alles ausgeführt wird
    class Programm
    {
        static void Main(string[] _)
        {
            // Erstellt zwei Instanzen der Klasse Benutzer
            Benutzer benutzer1 = new Benutzer("Ognjen", "Vojnovic", 19, "ognjen@email.com", "1234sifra", "2121-2121-2121-2121");
            Benutzer benutzer2 = new Benutzer("Mateo", "Tomic", 20, "mateo@email.com", "123444444", "1111-1111-1111-1111");

            // Gibt die Vornamen der beiden Benutzer aus
            Console.WriteLine(benutzer1.getVorname());
            Console.WriteLine(benutzer2.getVorname());

            // Sucht nach einem Benutzer mit einer bestimmten E-Mail und gibt dessen Vornamen aus
            // Du kannst auch was anderes ausgeben, z.B. die E-Mail des Benutzers (falls die getter Methode dafür existiert)
            Benutzer gesuchterBenutzer = Benutzer.getBenutzer("mateo@email.com");
            Console.WriteLine(gesuchterBenutzer.getVorname());

            // Ändert den Vornamen des ersten Benutzers
            benutzer1.setVorname("Ogi");
            Console.WriteLine(benutzer1.getVorname());
        }
    }
}
