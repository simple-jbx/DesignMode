using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode
{
    public sealed class Singleton
    {
        public static readonly Singleton instance = new Singleton();

        private Singleton() { }
    }
}
