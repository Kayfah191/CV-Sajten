using System.ComponentModel.DataAnnotations;

namespace CV_Sajten.Models
{
	public class Registrering
    {
		
        [Required(ErrorMessage = "Vänligen skriv ett användarnamn.")]
        [StringLength(255)]
        public string AnvandarNamn { get; set; }

        [Required(ErrorMessage = "Vänligen skriv ett lösenord.")]
        [DataType(DataType.Password)]
        [Compare("BekraftaLosenord", ErrorMessage = "Lösenorden matchar inte.")]
        public string Losenord { get; set; }

        [Required(ErrorMessage = "Vänligen bekräfta lösenordet.")]
        [DataType(DataType.Password)]
        [Display(Name = "Bekräfta lösenordet")]
        public string BekraftaLosenord { get; set; }

       

        [Required(ErrorMessage = "Vänligen skriv din e-postadress.")]
        [EmailAddress(ErrorMessage = "Ogiltig e-postadress.")]
        public string Epost { get; set; }

        [Required(ErrorMessage = "Vänligen skriv ditt telefonnummer.")]
        [Phone(ErrorMessage = "Ogiltigt telefonnummer.")]
        [Display(Name = "Telefonnummer")]
        public string TelefonNummer { get; set; }
    }
}


