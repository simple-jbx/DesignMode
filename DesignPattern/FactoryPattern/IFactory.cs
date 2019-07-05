using DesignPattern.simpleFactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryPattern
{
    interface IFactory
    {
        Operation CreateOperation();
    }
}
