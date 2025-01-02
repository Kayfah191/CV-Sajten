using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Sajten.Models
{
    public class Cv
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Kompetenser är obligatoriskt.")]
        [StringLength(225)]
        public string Kompetenser { get; set; }
        [Required(ErrorMessage = "Utbildning är obligatoriskt.")]
        [StringLength(225)]
        public string Utbildning { get; set; }
        [Required(ErrorMessage = "Erfarenheter är obligatoriskt.")]

        public string Erfarenheter { get; set; }
        [Required(ErrorMessage =" AnvänderID är oblugatorisk")] 
        public int AnvandareID { get; set; }
       

        [ForeignKey(nameof(AnvandareID))]
        public virtual Anvandare? Anvandare { get; set; }
    }

}

