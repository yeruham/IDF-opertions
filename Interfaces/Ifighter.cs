using System.Collections.Generic;
using IDF_opertions;

public interface Ifigher
{
    string name { get; set; }
    int rank { get; set; }
    bool isAlive { get; set; }
    List<Iweapon> weapons{ get; set; }
}