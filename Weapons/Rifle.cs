using System;

public class Rifle : Iweapon
{
    public string Name { get; set; }
    public int PowerLevel { get; set; }
    public string EffectiveFor { get; set; }

    public Rifle(string name, int powerLevel, string effectiveFor)
    {
        this.Name = name;
        this.PowerLevel = powerLevel;
        this.EffectiveFor = effectiveFor;
    }
}