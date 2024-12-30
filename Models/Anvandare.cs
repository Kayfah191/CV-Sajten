namespace CV_Sajten.Models
{
    public class Anvandare
    {

        public int ID { get; set; }
        public string Namn { get; set; }

        public string Email { get; set; }

        public Boolean isPrivat { get; set; }
          
        public string BildAdress { get; set; } 
      }
}
