using System.Collections.Generic;

public class IDFfirePower: Iorganization
{
    public string uniqueName { get; set; }
    public int SinceThan { get; set; }
    public string commander { get; set; }
    public string organizationOf { get; set; }


    private List<Iweapon> weapons = new List<Iweapon>();
    
    public void addWeapons(Iweapon weapon)
    {
        weapons.Add(weapon);
    }

    public void removeWeapons(Iweapon weapon)
    {
        weapons.Remove(weapon);
    }

    public List<Iweapon> getWeapons()
    {
        return weapons;
    }
}