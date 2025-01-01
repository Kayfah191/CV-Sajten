using System.ComponentModel.DataAnnotations;

namespace CV_Sajten.Models
{
	public class Registrering
	{
		[Required(ErrorMessage = "Vänligen skriv ett användarnamn.")]
		[StringLength(255)]
		public string AnvandarNamn { get; set; }
		[Required(ErrorMessage = "Vänligen skriv lösenord.")]
		[DataType(DataType.Password)]
		[Compare("BekraftaLosenord")]
		public string Losenord { get; set; }
		[Required(ErrorMessage = "Vänlingen bekräfta lösenordet")]
		[DataType(DataType.Password)]
		[Display(Name = "Bekrafta losenordet")]
		public string BekraftaLosenord { get; set; }
	}
}
