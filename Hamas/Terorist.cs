using System.Collections.Generic;
public class Terorist : Ifigher
{
    public string name { get; set; }
    public int rank { get; set; }
    public bool isAlive { get; set; }
    public List<Iweapon> weapons { get; set; }

    public Terorist(string name, int rank, bool isAlive, List<Iweapon> weapons)
    {
        this.name = name;
        this.rank = rank;
        this.isAlive = isAlive;
        this.weapons = weapons;
    }
}