using System;

public class F16 : Plane
{
    public F16(double bombWight) : base("F16", 10, "buildings", bombWight, 1, 50, 8)
    {
    }

    public override bool Attack()
    {
        if (FuelSupply <= 0 || RemainingAttacks <= 0)
        {
            return false;
        }

        RemainingAttacks -= 1;
        FuelSupply -= 6;
        return true;

    }
}