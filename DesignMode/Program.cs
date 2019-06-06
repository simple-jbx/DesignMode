using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DesignMode.simpleFactoryPattern;
using DesignMode.stragetyPattern;
using DesignMode.decoratorPattern;
using DesignMode.proxyPatten;
using DesignMode.FactoryPattern;
using DesignMode.Prototypepattern;
using DesignMode.TemplateMethodPattern;
using DesignMode.FacadePattern;
using DesignMode.Builderpattern;

namespace DesignMode
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
            //简单工厂模式测试
            Operation oper;
            oper = OperationFactory.createOperate("*");
            oper.NumberA = 1;
            oper.NumberB = 2;
            double result = oper.GetResult();
            Console.Out.WriteLine(result);
            
            //*/

            /*
            //策略模式测试
            Context context;
            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();

            //*/

            /*
            //装饰者模式
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA da = new ConcreteDecoratorA();
            ConcreteDecoratorB db = new ConcreteDecoratorB();

            da.SetComponent(c);
            db.SetComponent(da);
            db.Operation();
            //*/


            /*
            SchoolGirl mm = new SchoolGirl();
            mm.Name = "mm";

            Proxy proxy = new Proxy(mm);

            proxy.GiveDolls();
            proxy.GiveFlowers();
            proxy.GiveChocolate();
            //*/

            /*
            //工厂方法测试
            IFactory operFactory = new AddFactory();
            Operation oper = operFactory.CreateOperation();
            oper.NumberA = 1;
            oper.NumberB = 2;
            double result = oper.GetResult();
            Console.Out.WriteLine(result);
            //*/

            /*
            //原型模式 深复制与浅复制
            ConcretePrototype1 p1 = new ConcretePrototype1("I");
            ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
            Console.WriteLine("Cloned: {0}", c1.Id);
            //*/

            /*
            //模板方法
            AbstractClass c;
            c = new ConcreteClassA();
            c.TemplateMethod();

            c = new ConcreteClassB();
            c.TemplateMethod();
            //*/


            /*
            //外观模式
            Facade facade = new Facade();

            facade.MethodA();
            facade.MethodB();

            //*/

            /*
            //建造者模式
            Director director = new Director();
            Builder b1 = new ConcreteBuilder1();
            Builder b2 = new ConcreteBuilder2();

            director.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();

            director.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Show();
            //*/


            Console.ReadLine();

        }
    }
}
