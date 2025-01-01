using System.ComponentModel.DataAnnotations;

namespace CV_Sajten.Models
{
    public class Inlogg
    {
        [Required(ErrorMessage = "Vänligen skriv ett användarnamn.")]
        [StringLength(255)]
        public string AnvandarNamn { get; set; }
        [Required(ErrorMessage = "Vänligen skriv lösenord.")]
        [DataType(DataType.Password)]
        public string Losenord { get; set; }
        public bool RememberMe { get; set; }
    }
}

