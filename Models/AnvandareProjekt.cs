namespace CV_Sajten.Models
{

    // hela denna tabell/klass behövs enbart om vi vill
    //lagra mer information än användareID och ProjektID
    //annars sköter EF core det själv tydlligen
    public class AnvandareProjekt
    {
        //dessa två int-fält blir primärnyckeln
        public int AnvandareID { get; set; }
        public int ProjektID { get; set; }

       //detta är då den övriga informationen vi kanske vill lagra?
        public string Roll { get; set; }

        // navigering till Anvandare och Projekt-klasserna
        public Anvandare Anvandare { get; set; }
        public Projekt Projekt { get; set; }
    }
}
