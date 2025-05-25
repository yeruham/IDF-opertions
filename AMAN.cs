using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Reflection.Emit;
using System.Threading;

public class AMAN
{
    //list variable with data about all terorist 
    private List<DataTerorist> dataTerrorists = new List<DataTerorist>();

    //constractor that take list with all terorists from Hamas and turns each one to DataTerorist (class with information about terorist)
    public AMAN(Hamas hamas)
    {
        List<Terorist> terrorists = hamas.getTerrorists();

        foreach (Terorist terorist in terrorists)
        {
            int riskLevel = this.RiskLevel(terorist);
            DataTerorist newData = new DataTerorist(terorist, riskLevel);
            dataTerrorists.Add(newData);
        }
        //Console.WriteLine(dataTerrorists.Count);
    }

    //Calculate the risk level of a terrorist
    public int RiskLevel(Terorist terorist)
    {
        int riskLevel = 0;
        foreach (Iweapon weapon in terorist.weapons)
        {
            riskLevel += weapon.PowerLevel;
        }
        riskLevel *= terorist.rank;
        
        return riskLevel;
    }


    //receives information about a terrorist's location, and saves it with a timestamp
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

    //return list wite data about terrorist's (DataTerorist to each one) 
    public List<DataTerorist> getDataTerrorists()
    {
        return this.dataTerrorists;
    }

    //return list with DataTerorist, only those whose location was accepted
    public List<DataTerorist> getDataTerroristsWithLocation()
    {
        List<DataTerorist> terroristsToKill = new List<DataTerorist>();

        foreach (DataTerorist data in dataTerrorists)
        {
            if (data.terorist.isAlive && data.locations.Count > 0)
            {
                terroristsToKill.Add(data);
            }
        }
        //Console.WriteLine("terorist to kill " +terroristsToKill.Count);

        return terroristsToKill;
    }
}

public class DataTerorist
{
    public Terorist terorist;
    public List<string> locations = new List<string>();
    public DateTime time;
    public int numRepurts = 0;
    public int riskLevel;

    public DataTerorist(Terorist terorist, int riskLevel)
    {
        this.terorist = terorist;
        this.riskLevel = riskLevel;
    }

    public void report(string location, DateTime time)
    {
        this.locations.Add(location);
        this.time = time;
        numRepurts++;
    }


}