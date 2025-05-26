public class Cannon : Artillery
{
    public Cannon() : base("Cannon", 8, "open areas", "explosive shells", 4, 50, 40)
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