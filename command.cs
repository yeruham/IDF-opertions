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
        this.terroristsToKill = aman.getDataTerroristsWithLocation();
        this.attackTools = firePower.getWeapons();
    }

    
    public Terorist teroristWithMostReports()
    {
        int numReport = 0;
        Terorist mostReports = terroristsToKill[0].terorist;
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
        Console.WriteLine(terroristsToKill.Count);
        foreach (DataTerorist data in terroristsToKill)
        {
            Console.Write($"terorist: {data.terorist.name}. rank: {data.terorist.rank} risk: {data.riskLevel} weapons: ");
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
            isAvailable = weapon.availabilityCheck();
            if (isAvailable)
            {
                availableTools.Add(weapon);
            }
        }
        return availableTools;
    }

    public Terorist ection()
    {
        DataTerorist mostDangerous = terroristsToKill[0];
        List<DataTerorist> cannotBeKill = new List<DataTerorist>();
        int risklevel;
        bool killed = false;

        do
        {
            risklevel = 0;
            Console.WriteLine("the action start!!");
            foreach (DataTerorist data in terroristsToKill)
            {
                Console.WriteLine("terorist -----  " + data.terorist.name);
                if (data.riskLevel > risklevel && !cannotBeKill.Contains(data))
                {
                    Console.WriteLine($"the risk is {data.riskLevel}");
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
                    mostDangerous.terorist.isAlive = false;
                    Console.WriteLine($"The terrorist {mostDangerous.terorist.name} was eliminated with {weapon.Name}");
                    break;
                }
            }
            
        } while (!killed && cannotBeKill.Count < terroristsToKill.Count);
        
        return mostDangerous.terorist;
    }




}