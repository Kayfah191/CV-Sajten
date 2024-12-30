namespace CV_Sajten.Models;
public class Meddelanden
{
    public int ID { get; set; }
    public string Innehall { get; set; }
    public bool HarLasts { get; set; }
    public DateTime Datum { get; set; }
    
    public int AvsandareID { get; set; } 
    public int MottagareID { get; set; } 

    public Anvandare Avsandare { get; set; } 
    public Anvandare Mottagare { get; set; } 
}