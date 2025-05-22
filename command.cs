using System;
using System.Collections;
using System.Collections.Generic;

public class IDFcommand
{
    AMAN aman;
    IDFfirePower firePower;
    public List<DataTerorist> terroristsToKill;
    public List<IBomberWeapon> attackTools;

    public IDFcommand(AMAN aman, IDFfirePower firePower)
    {
        this.aman = aman;
        this.firePower = firePower;
        this.terroristsToKill = aman.getDataTerrorists();
        this.attackTools = firePower.getWeapons();
    }

    
    public Ifigher teroristWithMostReports()
    {
        int numReport = 0;
        Ifigher mostReports = terroristsToKill[0].terorist;
        foreach(DataTerorist data in terroristsToKill)
        {
            if (data.numReports > numReport)
            {
                mostReports = data.terorist;
            }
        }
        Console.WriteLine($"the terorist with most reports is {mostReports.name}. rank: {mostReports.rank}.");
        return mostReports;
    }

    public List<DataTerorist> getDataOfTerorist()
    {
        foreach (DataTerorist data in terroristsToKill)
        {
            Console.Write($"terorist: {data.terorist.name}. rank: {data.terorist.rank} weapons: ");
            foreach (Iweapon Weapon in data.terorist.weapons)
            {
                Console.Write(Weapon.Name + ", ");
            }
            Console.Write($"num reports: {data.numReports}. he was in locations: ");
            foreach(string location in data.locations)
            {
                Console.Write(location + ", ");
            }
            Console.WriteLine();
        }
        return terroristsToKill;
    }

    public List<IBomberWeapon> AvailableAttackTools()
    {
        return attackTools;
    }


}