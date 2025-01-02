namespace CV_Sajten.Models
{
    public class Projekt
    {
        public int ID { get; set; }
        public string Titel { get; set; }
        public string Beskrivning { get; set; }

        // n-m relation/navigering via mellantabellen. slopar vi den kan vi här ha en 
        //icollection direkt till anvandare-klassen.
        public ICollection<AnvandareProjekt> AnvandareProjekt { get; set; } = new List<AnvandareProjekt>();
    }
}
