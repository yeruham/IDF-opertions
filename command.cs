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
            if (data.numRepurts > numReport)
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
            Console.Write($"num reports: {data.numRepurts}. he was in locations: ");
            foreach(string location in data.locations)
            {
                Console.Write(location + ", ");
            }
            Console.WriteLine();
        }
        return terroristsToKill;
    }

    public List<IBomberWeapon> getAttackTools()
    {
        foreach (IBomberWeapon weapon in attackTools)
        {
            Console.WriteLine($"tool: {weapon.Name}. ");
        }
            return attackTools;
    }

    public List<IBomberWeapon> AvailableAttackTools()
    {
        List<IBomberWeapon> availableTools = new List<IBomberWeapon>();
        bool isAvailable;
        foreach (IBomberWeapon weapon in attackTools)
        {
            isAvailable = weapon.Attack();
            if (isAvailable)
            {
                availableTools.Add(weapon);
            }
        }
        return availableTools;
    }

    public Ifigher ection()
    {
        DataTerorist mostDangerous = terroristsToKill[0];
        List<DataTerorist> cannotBeKill = new List<DataTerorist>();
        int risklevel = 0;
        bool killed = false;

        do
        {
            foreach (DataTerorist data in terroristsToKill)
            {
                {
                    mostDangerous = data;
                    risklevel = data.riskLevel;
                }
            }
            cannotBeKill.Add(mostDangerous);

            List<IBomberWeapon> availableTools = AvailableAttackTools();

            foreach (IBomberWeapon weapon in availableTools)
            {
                if (weapon.EffectiveFor == mostDangerous.locations[mostDangerous.locations.Count - 1])
                {
                    killed = weapon.Attack();
                    Console.WriteLine($"The terrorist {mostDangerous.terorist.name} was eliminated");
                }
            }
            
        } while (!killed && cannotBeKill.Count < terroristsToKill.Count);
        
        return mostDangerous.terorist;
    }




}