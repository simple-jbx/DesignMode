using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.decoratorPattern
{
    abstract class Component
    {
        public abstract void Operation();
    }

    class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.Out.WriteLine("具体对象的操作");
        }
    }
}
