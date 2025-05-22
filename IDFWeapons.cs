using System;

public class F16 : Plane
{
    public F16() : base("F16", 10, "buildings", 0.5, 1, 50, 8)
    {
    }

    public override bool Attack()
    {
        if (this.FuelSupply <= 0)
        {
            return false;
        }

        return true;

    }
}

public class Cannon : Artillery
{
    public Cannon() : base("F16", 10, "buildings", 0.5, 1, 50, 8)
    {
    }

    public override bool Attack()
    {
        if (FuelSupply <= 0)
        {
            return false;
        }

        RemainingAttacks -= 1;
        FuelSupply -= 6;
        return true;

    }
}

public class Zik : Drone
{
    public Zik(string target) : base("F16", 10, "buildings", WeightCalculator(target), 1, 50, 8)
    {

    }

    private static double WeightCalculator(string target)
    {
        if (target == "man")
        {
            return 0.2;
        }
            return 0.1;
    }

    public override bool Attack()
    {
        if (this.FuelSupply <= 0)
        {
            return false;
        }

        return true;
    }

}