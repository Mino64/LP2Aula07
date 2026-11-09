using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Observers
{
    public abstract class AbstractStringSubject : ISubject<AbstractStringSubject>
    {
        private readonly ISet<IObserver<AbstractStringSubject>> observers;

        public string item;

        public string Item
        {
            get => item;
            protected set
            {
                item = value;
                foreach (IObserver<AbstractStringSubject> obs in observers) // in this case you can use var instead of IObserver<AbstractStringSubject> because its extremely long
                {
                    obs.Update(this);
                }
            }
        }

        public AbstractStringSubject()
        {
            observers = new HashSet<IObserver<AbstractStringSubject>>();
        }
        public void RegisterObserver(IObserver<AbstractStringSubject> obs)
        {
            observers.Add(obs);
        }

        public void RemoveObserver(IObserver<AbstractStringSubject> obs)
        {
            observers.Remove(obs);
        }
    }


}