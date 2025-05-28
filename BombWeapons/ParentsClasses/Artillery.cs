using System;

public class Artillery : IBomberWeapon
{
    public string Name { get; set; }
    public int PowerLevel { get; set; }
    public string EffectiveFor { get; set; }
    public object TypeBomb { get; set; }
    public int BombsAtOnce { get; set; }
    public int FuelSupply { get; set; }
    public int RemainingAttacks { get; set; }

    public Artillery(string name, int powerLevel, string effectiveFor, string typeBomb, int bombsAtOnce, int fuelSupply, int remainingAttacks)
    {
        this.Name = name;
        this.PowerLevel = powerLevel;
        this.EffectiveFor = effectiveFor;
        this.TypeBomb = typeBomb;
        this.BombsAtOnce = bombsAtOnce;
        this.FuelSupply = fuelSupply;
        this.RemainingAttacks = remainingAttacks;
    }

    public virtual bool Attack() { return false; }

    public bool availabilityCheck()
    {
        if (FuelSupply <= 0 || RemainingAttacks <= 0)
        {
            return false;
        }
        return true;
    }
}