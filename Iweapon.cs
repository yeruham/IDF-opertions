using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_opertions
{
    public interface Iweapon
    {
        string Name { get; set; }
        int PowerLevel { get; set; }
        string EffectiveFor { get; set; }

    }
}
