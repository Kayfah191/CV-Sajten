namespace CV_Sajten.Models
{
    public class Service:List<Cv>
    {
        public Service()
        {
            SampleData();
        }

        public void SampleData()
        {
            this.Add(new Cv
            {
                ID = 1,
                Kompetenser = "C#, .NET, SQL, Azure",
                Utbildning = "Civilingenjör i Datateknik, KTH",
                Erfarenheter = "3 års erfarenhet som systemutvecklare på TechCorp",
                AnvandareID = 1001
            }
                );
        }
    }
}
