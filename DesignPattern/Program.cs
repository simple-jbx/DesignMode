using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DesignPattern.simpleFactoryPattern;
using DesignPattern.stragetyPattern;
using DesignPattern.decoratorPattern;
using DesignPattern.proxyPatten;
using DesignPattern.FactoryPattern;
using DesignPattern.Prototypepattern;
using DesignPattern.TemplateMethodPattern;
using DesignPattern.FacadePattern;
using DesignPattern.Builderpattern;
using DesignPattern.ObserverPattern;
using DesignPattern.AdapterPattern;
using DesignPattern.MementoPattern;
using DesignPattern.IteratorPattern;
using System.Collections;

namespace DesignPattern
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

            /*
            //观察者模式
            ConcreteSubject s = new ConcreteSubject();
            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));

            s.SubjectState = "ABC";
            s.Notify();

            s.SubjectState = "DEF";
            s.Notify();

            //*/

            /*
            //适配器模式
            Target target = new Adapter();
            target.Request();
            //*/

            /*
            //备忘录模式
            //大战boss前
            GameRole gameRole = new GameRole();
            gameRole.GetInitState();
            gameRole.StateDisplay();

            //保存进度
            RoleStateCaretaker stateAdmin = new RoleStateCaretaker();
            stateAdmin.Memento = gameRole.SaveState();

            //大战Boss时，损耗严重
            gameRole.Fight();
            gameRole.StateDisplay();

            //恢复之前状态
            gameRole.RecoveryState(stateAdmin.Memento);
            gameRole.StateDisplay();
            //*/

            /*
            //迭代器模式V1
            Passenger bus324 = new Passenger();
            bus324[0] = "大鸟";
            bus324[1] = "小菜";
            bus324[2] = "行李";
            bus324[3] = "老外";

            //Iterator i = new ConcreteIterator(bus324);
            Iterator i = new ConcreteIteratorDesc(bus324);
            object item = i.First();
            while(!i.IsDone())
            {
                //System.Diagnostics.Debug.Print("{0} 请买车票！", i.CurrentItem()); 
                Console.WriteLine("{0} 请买车票！", i.CurrentItem());
                i.Next();
            }
            //*/


            /*
            PassengerNET bus324 = new PassengerNET();
            bus324[0] = "大鸟";
            bus324[1] = "小菜";
            bus324[2] = "行李";
            bus324[3] = "老外";

            IEnumerator iterator = bus324.GetEnumerator();
            while(iterator.MoveNext())
            {
                Console.WriteLine("{0} 请买车票", iterator.Current);
            }
            //*/

            /*foreach(var item in bus324)
            {
                Console.WriteLine("{0} 请买车票", item);
            }*/

            //*/

            /*
            PassengerNETGenerics bus324 = new PassengerNETGenerics();
            bus324[0] = "大鸟";
            bus324[1] = "小菜";
            bus324[2] = "行李";
            bus324[3] = "老外";

            IEnumerator iterator = bus324.GetEnumerator();
            while (iterator.MoveNext())
            {
                Console.WriteLine("{0} 请买车票", iterator.Current);
            }
            //*/
            Console.ReadLine();
        }
    }
}
