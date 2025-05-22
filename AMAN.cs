using System;
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
            dataTerrorists.Add(newData);
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


    public void report(string terorist, string location)
    {
        DateTime now = DateTime.Now;
        foreach (DataTerorist data in dataTerrorists)
        {
            if (data.terorist.name == terorist)
            {
                data.report(location, now);
                break;
            }
        }
    }


    public List<DataTerorist> getDataTerrorists()
    {
        List<DataTerorist> terroristsToKill = new List<DataTerorist>();

        foreach (DataTerorist data in dataTerrorists)
        {
            if (data.terorist.isAlive && data.locations.Count > 0)
            {
                terroristsToKill.Add(data);
            }
        }

        return terroristsToKill;
    }
}

public class DataTerorist
{
    public Ifigher terorist;
    public List<string> locations = new List<string>();
    public DateTime time;
    public int numRepurts = 0;
    public int riskLevel;

    public DataTerorist(Ifigher terorist, int riskLevel)
    {
        this.terorist = terorist;
        this.riskLevel = riskLevel;
    }

    public void report(string location, DateTime time)
    {
        this.locations.Add(location);
        this.time = time;
    }


}