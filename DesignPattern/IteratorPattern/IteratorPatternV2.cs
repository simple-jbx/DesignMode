using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.IteratorPattern
{
    //非泛型
    public class PassengerNET : IEnumerable
    {
        private IList<object> items = new List<object>();       

        public void getOn(string passengerName)
        {
            items.Add(passengerName);
        }

        //返回聚集总个数
        public int Count { get => items.Count; }

        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }

        //里氏代换原则
        public IEnumerator GetEnumerator()
        {
            return new ConcreteIteratorNET(this);
        }
    }

    public class ConcreteIteratorNET : IEnumerator
    {
        private PassengerNET passengers = null;

        private int CurrentIndex = -1;

        public object Current
        {
            get { return passengers[CurrentIndex]; }
        }

        public ConcreteIteratorNET(PassengerNET passengers)
        {
            this.passengers = passengers;
        }

        public bool MoveNext()
        {
            CurrentIndex++;
            return CurrentIndex < passengers.Count;
        }

        public void Reset()
        {
            CurrentIndex = -1;
        }
    }
}
