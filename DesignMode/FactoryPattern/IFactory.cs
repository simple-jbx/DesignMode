using DesignMode.simpleFactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode.FactoryPattern
{
    interface IFactory
    {
        Operation CreateOperation();
    }
}
