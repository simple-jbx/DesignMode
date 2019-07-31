using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.IteratorPattern
{
    //泛型
    public class PassengerNETGenerics : IEnumerable<string>
    { 
        private IList<string> items = new List<string>();

        public void getOn(string passengerName)
        {
            items.Add(passengerName);
        }

        //返回聚集总个数
        public int Count { get => items.Count; }

        public string this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }

        public IEnumerator<string> GetEnumerator()
        {
            return new ConcreteNETGenericsIterator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new ConcreteNETGenericsIterator(this);
        }
    }

    public class ConcreteNETGenericsIterator : IEnumerator<string>
    {

        private int CurrentIndex = -1;
        private PassengerNETGenerics passengers = null;

        object IEnumerator.Current
        {
            get { return this.passengers[this.CurrentIndex]; }
        }

        public string Current
        {
            get { return this.passengers[this.CurrentIndex]; }
        }

        public ConcreteNETGenericsIterator(PassengerNETGenerics passengerNETGenerics)
        {
            this.passengers = passengerNETGenerics;
        }

        public void Dispose()
        {
            GC.Collect();
        }

        public bool MoveNext()
        {
            this.CurrentIndex++;
            return this.CurrentIndex < this.passengers.Count;
        }

        public void Reset()
        {
            this.CurrentIndex = -1;
        }

        void IDisposable.Dispose()
        {
            GC.Collect();
        }

        bool IEnumerator.MoveNext()
        {
            this.CurrentIndex++;
            return this.CurrentIndex < this.passengers.Count;
        }

        void IEnumerator.Reset()
        {
            this.CurrentIndex = -1;
        }
    }
}
