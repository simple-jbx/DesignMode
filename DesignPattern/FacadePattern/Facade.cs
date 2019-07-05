using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FacadePattern
{
    class SubSystemOne
    {
        public void MethodOne()
        {
            Console.WriteLine(" 子系统方法一");
        }
    }

    class SubSystemTwo
    {
        public void MethodTwo()
        {
            Console.WriteLine(" 子系统方法二");
        }
    }

    class SubSystemThree
    {
        public void MethodThree()
        {
            Console.WriteLine(" 子系统方法三");
        }
    }

    class SubSystemFour
    {
        public void MethodFour()
        {
            Console.WriteLine(" 子系统方法四");
        }
    }

    class Facade
    {
        SubSystemOne subSystemOne;
        SubSystemTwo subSystemTwo;
        SubSystemThree subSystemThree;
        SubSystemFour subSystemFour;

        public Facade()
        {
            subSystemOne = new SubSystemOne();
            subSystemTwo = new SubSystemTwo();
            subSystemThree = new SubSystemThree();
            subSystemFour = new SubSystemFour();
        }

        public void MethodA()
        {
            Console.WriteLine("\n 方法组A（）----------");
            subSystemOne.MethodOne();
            subSystemTwo.MethodTwo();
            subSystemFour.MethodFour();
        }

        public void MethodB()
        {
            Console.WriteLine("\n 方法组B（）---------");
            subSystemTwo.MethodTwo();
            subSystemThree.MethodThree();
        }
    }
}
