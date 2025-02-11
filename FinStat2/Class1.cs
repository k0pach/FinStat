using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinStat2
{
    // Интерфейсы IObservable и IObserver
    public interface IObservable
    {
        void AddObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }

    public class ConcreteObservable : IObservable
    {
        private List<IObserver> observers;

        public ConcreteObservable()
        {
            observers = new List<IObserver>();
        }

        public void AddObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update();
            }
        }
    }

    public interface IObserver
    {
        void Update();
    }

    public class ConcreteObserver : IObserver
    {
        private Action updateAction;

        public ConcreteObserver(Action updateAction)
        {
            this.updateAction = updateAction;
        }

        public void Update()
        {
            updateAction();
        }
    }

    public class Transaction
    {
        string title;
        string transType;
        string category;
        double sum;
        string description;

        public Transaction(string title, string transType, string category, double sum, string description)
        {
            this.title = title;
            this.transType = transType;
            this.category = category;
            this.sum = sum;
            this.description = description;
        }

        public string Title
        {
            get { return title; }
        }

        public string TransType
        {
            get { return transType; }
        }

        public string Category
        {
            get { return category; }
        }

        public double Sum
        {
            get { return sum; }
        }

        public string Description
        {
            get { return description; }
        }


    }

    public static class GlobalVars
    {
        public static List<string> expendList = new List<string>
        {
            "Еда",
            "Транспорт",
            "Кошка-жена"
        };

        public static List<string> incomeList = new List<string>
        {
            "Работа",
            "Милостыня",
            "Мамуля"
        };

        public static Transaction transaction;

    }
}
