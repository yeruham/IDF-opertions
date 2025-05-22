using System.Collections.Generic;
using IDF_opertions;

public interface Ifigher
{
    string name { get; set; }
    int rank { get; set; }
    bool isAlive { get; set; }
    List<Iweapon> weapons{ get; set; }
}


public class Terorist: Ifigher
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