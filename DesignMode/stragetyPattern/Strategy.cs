using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.stragetyPattern
{
    //策略模式还可以和工厂模式结合起来使用
    abstract class Strategy
    {
        //算法方法
        public abstract void AlgorithmInterface();
    }

    class ConcreteStrategyA : Strategy
    {
        //算法A实现方法
        public override void AlgorithmInterface()
        {
            Console.Out.WriteLine("算法A实现");
        }
    }

    class ConcreteStrategyB : Strategy
    {
        //算法B实现方法
        public override void AlgorithmInterface()
        {
            Console.Out.WriteLine("算法B实现");
        }
    }

    class ConcreteStrategyC : Strategy
    {
        //算法C实现方法
        public override void AlgorithmInterface()
        {
            Console.Out.WriteLine("算法C实现");
        }
    }
}
