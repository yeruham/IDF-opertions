public interface IBomberWeapon
{
    double Bombweight { get; set; }
    int BombsAtOnce { get; set; }
    int FuelSupply { get; set; }
    int RemainingAttacks { get; set; }

    bool Attack();
}

