using System;

public class F16 : Plane
{
    public F16(double typeBomb) : base("F16", 10, "buildings", typeBomb, 1, 50, 8)
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
    public Cannon() : base("Cannon", 8, "open areas", "explosive shells",4 , 50, 40)
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
    public Zik(string target) : base("Zik", 6, "people, vehicles", ArmamentType(target), 1, 20, 3)
    {

    }

    private static double ArmamentType(string target)
    {
        if (target == "man")
        {
            return 0.1;
        }
            return 0.3;
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