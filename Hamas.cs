using System.Collections.Generic;

public class Hamas : Iorganization
{
    public string uniqueName { get; set; }
    public int SinceThan { get; set; }
    public string commander { get; set; }
    public string organizationOf { get; set; }
 
    private List<Ifigher> terrorists = new List<Ifigher>();

    public Hamas()
    {
        this.uniqueName = "Hamas";
        this.SinceThan = 1990;
        this.commander = "Sinwar";
        this.organizationOf = "terrorism";

    }

    public void addTerrorist(Ifigher terrorist)
    {
        terrorists.Add(terrorist);
    }

    public void removeTerrorist(Ifigher terrorist)
    {
        terrorists.Remove(terrorist);
    }

    public List<Ifigher> getTerrorists()
    {
        return terrorists;
    }

}