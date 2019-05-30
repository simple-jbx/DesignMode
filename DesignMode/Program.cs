﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DesignMode.simpleFactoryPattern;
using DesignMode.stragetyPattern;
using DesignMode.decoratorPattern;
using DesignMode.proxyPatten;

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





            Console.ReadLine();

        }
    }
}
