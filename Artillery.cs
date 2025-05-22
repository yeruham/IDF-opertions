using System;

public class Artillery : Iweapon, IBomberWeapon
{
    public string Name { get; set; }
    public int PowerLevel { get; set; }
    public string EffectiveFor { get; set; }
    public double Bombweight { get; set; }
    public int BombsAtOnce { get; set; }
    public int FuelSupply { get; set; }
    public int RemainingAttacks { get; set; }

    public Artillery(string name, int powerLevel, string effectiveFor, double bombweight, int bombsAtOnce, int fuelSupply, int remainingAttacks)
    {
        this.Name = name;
        this.PowerLevel = powerLevel;
        this.EffectiveFor = effectiveFor;
        this.Bombweight = bombweight;
        this.BombsAtOnce = bombsAtOnce;
        this.FuelSupply = fuelSupply;
        this.RemainingAttacks = remainingAttacks;
    }

    public virtual bool Attack() { return false; }
}