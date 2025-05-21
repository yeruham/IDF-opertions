using System;

public class plane : Iweapon, IBomberWeapon
{
    public string Name { get; set; }
    public int PowerLevel { get; set; }
    public string EffectiveFor { get; set; }
    public int Bombweight { get; set; }
    public int ThrowsInABlow { get; set; }
    public int FuelSupply { get; set; }
    public string BombBalance { get; set; }

    public plane(string name, int powerLevel, string effectiveFor, int bombweight, int throwsInABlow, int fuelSupply, string bombBalance)
    {
        this.Name = name;
        this.PowerLevel = powerLevel;
        this.EffectiveFor = effectiveFor;
        this.Bombweight = bombweight;
        this.ThrowsInABlow = throwsInABlow;
        this.FuelSupply = fuelSupply;
        this.BombBalance = bombBalance;
    }
}