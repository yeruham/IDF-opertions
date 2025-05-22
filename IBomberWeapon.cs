public interface IBomberWeapon : Iweapon
{
    double Bombweight { get; set; }
    int BombsAtOnce { get; set; }
    int FuelSupply { get; set; }
    int RemainingAttacks { get; set; }

    bool Attack();
}

