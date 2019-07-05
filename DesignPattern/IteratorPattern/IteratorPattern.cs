using System.Collections.Generic;

namespace DesignPattern.IteratorPattern
{
    //Iterator 迭代器抽象类
    abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();
    }

    //Aggregate聚集抽象类
    abstract class Aggregate
    {
        public abstract Iterator CreateIterator();//创建迭代器
    }

    //具体聚集类 继承Aggregate
    class ConcreteAggregate : Aggregate
    {
        private IList<object> items = new List<object>();
        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
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
        private ConcreteAggregate aggregate;//定义了一个具体聚集对象
        private int current = 0;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        //得到第一个聚集对象
        public override object First()
        {
            return aggregate[0];
        }

        public override object Next()
        {
            object ret = null;
            current++;
            if(current < aggregate.Count)
            {
                ret = aggregate[current];
            }
            return ret;
        }

        public override bool IsDone()
        {
            return current >= aggregate.Count ? true : false;
        }

        public override object CurrentItem()
        {
            return aggregate[current];
        }
    }

    //逆序遍历
    class ConcreteIteratorDesc : Iterator
    {
        private ConcreteAggregate aggregate;
        private int current = 0;

        public ConcreteIteratorDesc(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
            current = aggregate.Count - 1;
        }

        public override object First()
        {
            return aggregate[aggregate.Count - 1];
        }

        public override object Next()
        {
            object ret = null;
            current--;
            if(current >= 0)
            {
                ret = aggregate[current];
            }
            return ret;
        }

        public override object CurrentItem()
        {
            return aggregate[current];
        }

        public override bool IsDone()
        {
            return current < 0 ? true : false;
        }
    }
}
