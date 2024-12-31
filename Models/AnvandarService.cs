

namespace CV_Sajten.Models
{
    public class AnvandarService:List<Anvandare>
    {
        public AnvandarService()
        {
            SampleData();
        }

        public void SampleData()
        {
            this.Add(new Anvandare
            {
                ID = 1,
                Namn = "Anna Andersson",
                Email = "anna.andersson@example.com",
                isPrivat = true,
                BildAdress = "https://example.com/images/anna.jpg"
            });
            this.Add(new Anvandare
            {
                ID = 2,
                Namn = "Erik Svensson",
                Email = "erik.svensson@example.com",
                isPrivat = false,
                BildAdress = "https://example.com/images/erik.jpg"
            });

        }
    }
}
