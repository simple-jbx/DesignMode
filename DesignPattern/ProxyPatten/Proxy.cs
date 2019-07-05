using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.proxyPatten
{
    class Proxy
    {
        Pursuit gg;
        public Proxy(SchoolGirl mm)
        {
            gg = new Pursuit(mm);
        }

        public void GiveFlowers()
        {
            gg.GiveFlowers();
        }

        public void GiveDolls()
        {
            gg.GiveDolls();
        }

        public void GiveChocolate()
        {
            gg.GiveChocolate();
        }
    }
}
