using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_opertions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rifle rifle = new Rifle("m16", 3, "man");
            Knife knife = new Knife("ledarman", 1, "man");
            F16 f16 = new F16(1);
            Cannon cannon = new Cannon();
            Zik zik = new Zik("man");
            Hamas hamas = new Hamas();
            Terorist terorist1 = new Terorist("mochmad", 5, true, new List<Iweapon> { rifle, knife});
            Terorist terorist2 = new Terorist("macmud", 3, true, new List<Iweapon> { rifle, knife });
            Terorist terorist3 = new Terorist("abdalla", 1, true, new List<Iweapon> { rifle });
            Terorist terorist4 = new Terorist("ibraim", 2, true, new List<Iweapon> { knife });
            Terorist terorist5 = new Terorist("yosuf", 3, true, new List<Iweapon> { rifle});
            hamas.addTerrorist(terorist5);
            hamas.addTerrorist(terorist4);
            hamas.addTerrorist(terorist3);
            hamas.addTerrorist(terorist1);
            hamas.addTerrorist(terorist2);
            IDFfirePower firePower = new IDFfirePower();
            firePower.addWeapons(zik);
            firePower.addWeapons(f16);
            firePower.addWeapons(cannon);
            AMAN aman = new AMAN(hamas);
            aman.report("mochmad", "buildings");
            aman.report("abdalla", "buildings");
            aman.report("yosuf", "home");
            aman.report("yosuf",  "hiding");
            IDFcommand command = new IDFcommand(aman , firePower);

            Menu menu = new Menu(command);
            menu.displayMenu();
        }
    }
}
