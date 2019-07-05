using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Prototypepattern
{
    abstract class Prototype
    {
        private String id;

        public Prototype(String id)
        {
            this.id = id;
        }

        public String Id
        {
            get { return id; }
        }

        public abstract Prototype Clone();
    }

    class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(String id) : base(id)
        {

        }

        public override Prototype Clone()
        {
            /*
                创建当前对象的浅表副本。方法是创建一个新对象，然后将当前对象的非静态字段复制到该新对象。如果字段是值类型的，则对
            该字段进行逐位复制。如果字段是引用类型，则复制引用但不复制引用的对象；因此，原始对象及其副本引用同一对象。
            */
            return (Prototype)this.MemberwiseClone();
        }
    }
}
