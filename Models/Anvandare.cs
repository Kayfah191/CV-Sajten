using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CV_Sajten.Models
{
    public class Anvandare 
    {
        public int ID { get; set; }
        public string Namn { get; set; }
        public string Email { get; set; }
        public string Losenord { get; set; }
        public bool isPrivat { get; set; }
        public string BildAdress { get; set; }
        public virtual ICollection<Cv> Cvs { get; set; }
    }

}
