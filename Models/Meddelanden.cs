namespace CV_Sajten.Models;
public class Meddelanden
{
    public int id { get; set; }
    public string innehall { get; set; }
    public bool harLasts { get; set; }
    public DateTime datum { get; set; }

    //TODO foreign-keys =D
}