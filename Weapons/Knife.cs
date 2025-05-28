using System;

public class Knife : Iweapon
{
    public string Name { get; set; }
    public int PowerLevel { get; set; }
    public string EffectiveFor { get; set; }

    public Knife(string name, int powerLevel, string effectiveFor)
    {
        this.Name = name;
        this.PowerLevel = powerLevel;
        this.EffectiveFor = effectiveFor;
    }
}