namespace CV_Sajten.Models
{
    public class AnvandareProjekt
    { public int ID { get; set; }
    public string Roll { get; set; }

        public int AvsandareID { get; set; }
        public int ProjektID { get; set; }

        public Anvandare Avsandare { get; set; }
        public Projekt Projekt { get; set; }
    }
}
