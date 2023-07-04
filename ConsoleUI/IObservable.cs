using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    //Subject
    internal interface IObservable
    {
        //Register or remove the observer
        public void RegisterObserver(IObserver o);
        public void RemoveObserver(IObserver o);

        //Notify all observers when the Observers state has changed
        public void NotifyObserver();
    }
}
