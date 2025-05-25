using System;
using System.Collections;
using System.Collections.Generic;

public class IDFcommand
{
    AMAN aman;
    IDFfirePower firePower;
    public List<DataTerorist> allterorists;
    public List<DataTerorist> terroristsToKill;
    public List<IBomberWeapon> attackTools;

    public IDFcommand(AMAN aman, IDFfirePower firePower)
    {
        this.aman = aman;
        this.firePower = firePower;
        this.allterorists = aman.getDataTerrorists();
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
        foreach (DataTerorist data in allterorists)
        {
            Console.Write($"terorist: {data.terorist.name}. rank: {data.terorist.rank} risk: {data.riskLevel} weapons: ");
            foreach (Iweapon Weapon in data.terorist.weapons)
            {
                Console.Write(Weapon.Name + ", ");
            }
            Console.Write($"num reports: {data.numRepurts}.");
            if (data.locations.Count > 0)
            {
                Console.Write(" he was in locations: ");
                foreach (string location in data.locations)
                {
                    Console.Write(location + " - ");
                }
                Console.Write($"last position in time {data.time}");
            }
            else
            {
                Console.Write(" his location is unknown");
            }
            
            Console.WriteLine(".");
        }
        return allterorists;
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

    public bool killTerrorist(string name)
    {
        DataTerorist teroristToKill = terroristsToKill[0];
        bool teroristExsit = false;
        foreach (DataTerorist data in terroristsToKill)
        {
            if (data.terorist.name == name)
            {
                teroristToKill = data;
                teroristExsit = true;
                break;
            }
        }

        if (!teroristExsit)
        {
            Console.WriteLine($"the terrorist -{name}- does not exist, or his location is unknown.");
            return false;
        }
        if (!teroristToKill.terorist.isAlive)
        {
            Console.WriteLine("The terrorist is already dead!");
            return false;
        }

        List<IBomberWeapon> availableTools = AvailableAttackTools();

        foreach (IBomberWeapon weapon in availableTools)
        {
            if (weapon.EffectiveFor == teroristToKill.locations[teroristToKill.locations.Count - 1])
            {
                weapon.Attack();
                teroristToKill.terorist.isAlive = false;
                Console.WriteLine($"The terrorist {teroristToKill.terorist.name} was eliminated with {weapon.Name}");
                return true;
            }
        }

        Console.WriteLine($"No weapon was found to {teroristToKill.locations[teroristToKill.locations.Count - 1]}, the assassination did not take place.");

        return false;
    }

    public Terorist action()
    {
        DataTerorist mostDangerous = terroristsToKill[0];
        List<DataTerorist> cannotBeKill = new List<DataTerorist>();
        int risklevel;
        bool killed = false;

        do
        {
            risklevel = 0;
            //Console.WriteLine("the action start!!");
            foreach (DataTerorist data in terroristsToKill)
            {
                //Console.WriteLine("terorist -----  " + data.terorist.name);
                if (data.terorist.isAlive && data.riskLevel > risklevel && !cannotBeKill.Contains(data))
                {
                    //Console.WriteLine($"the risk is {data.riskLevel}");
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