using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.proxyPatten
{
    class Pursuit : IGiveGift
    {
        SchoolGirl mm;
        public Pursuit(SchoolGirl mm)
        {
            this.mm = mm;
        }

        public void GiveDolls()
        {
            Console.Out.WriteLine(mm.Name + " 送你洋娃娃");
        }

        public void GiveFlowers()
        {
            Console.Out.WriteLine(mm.Name + " 送你鲜花");
        }

        public void GiveChocolate()
        {
            Console.Out.WriteLine(mm.Name + " 送你巧克力");
        }
    }
}
