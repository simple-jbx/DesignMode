using System.Collections.Generic;

namespace DesignPattern.IteratorPattern
{
    //Iterator 迭代器抽象类
    abstract class Iterator
    {
        public abstract object First();//第一个
        public abstract object Next();//下一个
        public abstract bool IsDone();//是否结束
        public abstract object CurrentItem();//当前这个
    }

    //Aggregate聚集抽象类
    abstract class Aggregate
    {
        public abstract Iterator CreateIterator();//创建迭代器
    }

    //具体聚集类 继承Aggregate
    class Passenger : Aggregate
    {
        private IList<object> items = new List<object>();
        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public void getOn(string passengerName)
        {
            this.items.Add(passengerName);
        }

        //返回聚集总个数
        public int Count { get => items.Count; }

        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }
    }

    //ConcreteIterator具体迭代器类，继承Iterator, 顺序遍历
    class ConcreteIterator : Iterator
    {
        private Passenger passengers;//定义了一个具体聚集对象
        private int current = 0;

        public ConcreteIterator(Passenger passengers)
        {
            this.passengers = passengers;
        }

        //得到第一个聚集对象
        public override object First()
        {
            return passengers[0];
        }

        public override object Next()
        {
            object ret = null;
            current++;
            if(current < passengers.Count)
            {
                ret = passengers[current];
            }
            return ret;
        }

        public override bool IsDone()
        {
            return current >= passengers.Count ? true : false;
        }

        public override object CurrentItem()
        {
            return passengers[current];
        }
    }

    //逆序遍历
    class ConcreteIteratorDesc : Iterator
    {
        private Passenger passengers;
        private int current = 0;

        public ConcreteIteratorDesc(Passenger passengers)
        {
            this.passengers = passengers;
            current = passengers.Count - 1;
        }

        public override object First()
        {
            return passengers[passengers.Count - 1];
        }

        public override object Next()
        {
            object ret = null;
            current--;
            if(current >= 0)
            {
                ret = passengers[current];
            }
            return ret;
        }

        public override object CurrentItem()
        {
            return passengers[current];
        }

        public override bool IsDone()
        {
            return current < 0 ? true : false;
        }
    }
}
