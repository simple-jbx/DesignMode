﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AdapterPattern
{
    //客户所期待的接口。目标可以是具体的或抽象的类，也可以是接口。
    class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("普通请求！");
        }
    }

    class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("特殊请求！");
        }
    }

    class Adapter : Target
    {
        private Adaptee adaptee = new Adaptee();

        public override void Request()
        {
            adaptee.SpecificRequest();
        }
    }
}
