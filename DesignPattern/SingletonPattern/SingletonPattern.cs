using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SingletonPattern
{

    public sealed class SingletonV1
    {
        private static SingletonV1 instance;

        private SingletonV1() { }

        public static SingletonV1 getInstance()
        {
            if(instance == null)
            {
                instance = new SingletonV1();
            }
            return instance;
        }
    }

    public sealed class SingletonV2
    {
        private static SingletonV2 instance;

        //静态只读的辅助对象
        private static readonly object syncObject = new object();

        public SingletonV2 getInstance()
        {           
            //在同一时刻加了锁的那部分程序只有一个线程可以进入
            lock (syncObject)
            {
                if (instance == null)
                {
                    instance = new SingletonV2();
                }
            }
            return instance;
        }
    }

    public sealed class SingletonV3
    {
        private static SingletonV3 instance;

        //静态只读的进程辅助对象
        private static readonly object syncObject = new object();

        public SingletonV3 getInstance()
        {
            if (instance == null)
            {
                //在同一时刻加了锁的那部分程序只有一个线程可以进入
                lock (syncObject)
                {
                    if (instance == null)
                    {
                        instance = new SingletonV3();
                    }
                }
            }
            return instance;
        }
    }

    public sealed class SingletonV4
    {
        /*
           在实际应用中，C#与公共语言运行库也提供了一种‘静态初始化’方法，
       这种方法不需要开发人员显式地编写线程安全代码，即可解决多线程环境下
       它是不安全的问题。
       */
        private static readonly SingletonV4 instance = new SingletonV4();

       /*static SingletonV4()
        {
            instance = new SingletonV4();
        }
        */

        private SingletonV4()
        {

        }

        public static SingletonV4 GetInstance()
        {
            return instance;
        }
    }
}
