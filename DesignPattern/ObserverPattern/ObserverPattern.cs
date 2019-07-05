using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ObserverPattern
{
    abstract class Observer
    {
        public abstract void Update();
    }

    //主题/抽象通知者
    abstract class Subject
    {
        private IList<Observer> observers = new List<Observer>();

        //增加观察者
        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        //移出观察者
        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        //通知
        public void Notify()
        {
            foreach(Observer o in observers)
            {
                o.Update();
            }
        }
    }

    //具体主题/具体通知者
    class ConcreteSubject : Subject
    {
        //具体被观察者状态
        private String subjectState;

        public String SubjectState { get => subjectState; set => subjectState = value; }
    }

    //具体观察者
    class ConcreteObserver : Observer
    {
        private String name;
        private String observerState;
        private ConcreteSubject subject;

        public ConcreteObserver(ConcreteSubject subject, String name)
        {
            this.subject = subject;
            this.name = name;
        }

        public override void Update()
        {
            observerState = subject.SubjectState;
            Console.WriteLine("观察者{0}的新状态是{1}", name, observerState);
        }

        public ConcreteSubject Subject { get => subject; set => subject = value; }
    }
}
