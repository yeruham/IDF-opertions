using System.Collections.Generic;

public class IDFfirePower: Iorganization
{
    public string uniqueName { get; set; }
    public int SinceThan { get; set; }
    public string commander { get; set; }
    public string organizationOf { get; set; }


    private List<IBomberWeapon> weapons = new List<IBomberWeapon>();

    public IDFfirePower()
    {
        this.uniqueName = "IDFfirePower";
        this.SinceThan = 1950;
        this.commander = "Eyal Zamir";
        this.organizationOf = "I.D.F";

    }

    public void addWeapons(IBomberWeapon weapon)
    {
        weapons.Add(weapon);
    }

    public void removeWeapons(IBomberWeapon weapon)
    {
        weapons.Remove(weapon);
    }

    public List<IBomberWeapon> getWeapons()
    {
        return weapons;
    }
}