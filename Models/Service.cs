namespace CV_Sajten.Models
{
    public class Service:List<Anvandare>
    {
        public Service()
        {
            SampleData();
        }

        public void SampleData()
        {
            this.Add(new Anvandare
            {
            
      Namn ="Rickard",
     Email="hhh@gmail.com",
     isPrivat=true,
      BildAdress = "",
    }
                );
        }
    }
}
