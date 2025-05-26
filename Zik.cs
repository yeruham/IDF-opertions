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
        if (this.FuelSupply <= 0 || RemainingAttacks <= 0)
        {
            return false;
        }

        RemainingAttacks -= 1;
        FuelSupply -= 6;
        return true;
    }

}