using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StragetyPattern
{
    //上下文
    class Context
    {
        Strategy strategy;

        //初始化传入具体策略
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        //上下文接口 根据具体策略对象，调用其算法
        public void ContextInterface()
        {
            strategy.AlgorithmInterface();
        }
    }
}
