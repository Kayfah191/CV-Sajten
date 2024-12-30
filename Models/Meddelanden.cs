namespace CV_Sajten.Models;
public class Meddelanden
{
    public int id { get; set; }
    public string innehall { get; set; }
    public bool harLasts { get; set; }
    public DateTime datum { get; set; }
    
    public int AvsandareID { get; set; } 
    public int MottagareID { get; set; } 

    public Anvandare Avsandare { get; set; } 
    public Anvandare Mottagare { get; set; } 
}