using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DesignMode.simpleFactoryPattern;
using DesignMode.stragetyPattern;

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
            
            */

            ///*
            //策略模式测试
            Context context;
            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();

            Console.ReadLine();
        }
    }
}
