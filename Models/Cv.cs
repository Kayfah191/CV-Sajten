using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Sajten.Models
{
    public class Cv
    {
        public int Id { get; set; }
        public string Kompetenser { get; set; }
        public string Utbildning { get; set; }
        public string Erfarenheter { get; set; }
        public int AnvandareID { get; set; }

        [ForeignKey(nameof(AnvandareID))]
        public virtual Anvandare? Anvandare { get; set; }
    }

}

