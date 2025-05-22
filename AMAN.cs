using System.Collections.Generic;
using System.Data.Common;
using System.Reflection.Emit;
using System.Threading;

public class AMAN
{
    private List<DataTerorist> dataTerrorists = new List<DataTerorist>();

    public AMAN(Hamas hamas)
    {
        List<Ifigher> terrorists = hamas.getTerrorists();

        foreach (Ifigher terorist in terrorists)
        {
            int riskLevel = this.RiskLevel(terorist);
            DataTerorist newData = new DataTerorist(terorist, riskLevel);
        }
    }

    public int RiskLevel(Ifigher terorist)
    {
        int riskLevel = 0;
        foreach (Iweapon weapon in terorist.weapons)
        {
            riskLevel += weapon.PowerLevel;
        }
        riskLevel *= terorist.rank;
        
        return riskLevel;
    }

    public List<DataTerorist> getDataTerrorists()
    {
        List<DataTerorist> newDataTerrorists = new List<DataTerorist>();

        foreach (DataTerorist data in dataTerrorists)
        {
            if (data.terorist.isAlive && data.locations.Count > 0)
            {
                newDataTerrorists.Add(data);
            }
        }

        return newDataTerrorists;
    }
}

public class DataTerorist
{
    public Ifigher terorist;
    public List<string> locations = new List<string>();
    public string time;
    public int numRepurts = 0;
    public int riskLevel;

    public DataTerorist(Ifigher terorist, int riskLevel)
    {
        this.terorist = terorist;
        this.riskLevel = rating;
    }

    public void report(string location, string time)
    {
        this.locations.Add(location);
        this.time = time;
    }


}