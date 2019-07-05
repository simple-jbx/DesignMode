using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.decoratorPattern;

namespace DesignPattern.decoratorPattern
{
    abstract class Decorator : Component
    {
        protected Component component;

        public void SetComponent(Component component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            if(component != null)
            {
                component.Operation();
            }
        }
    }

    class ConcreteDecoratorA : Decorator
    {
        public override void Operation()
        {
            Console.Out.WriteLine("具体装饰对象A的操作");
            base.Operation();
        }
    }

    class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            Console.Out.WriteLine("具体装饰对象B的操作");
            base.Operation();
        }
    }
}
