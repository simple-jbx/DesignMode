using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DesignMode.simpleFactoryPattern;

namespace DesignMode
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation oper;
            oper = OperationFactory.createOperate("+");
            oper.NumberA = 1;
            oper.NumberB = 2;
            double result = oper.GetResult();
            Console.Out.WriteLine(result);
            StreamReader re = new StreamReader(System.IO.Stream.Null);
            re.ReadLine();

        }
    }
}
