public interface IBomberWeapon : Iweapon
{
    object TypeBomb { get; set; }
    int BombsAtOnce { get; set; }
    int FuelSupply { get; set; }
    int RemainingAttacks { get; set; }

    bool Attack();

    bool availabilityCheck();

}

