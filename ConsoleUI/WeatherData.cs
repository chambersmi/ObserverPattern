using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class WeatherData : IObservable
    {
        private List<IObserver> observers;
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void NotifyObserver()
        {
            foreach(IObserver observer in observers)
            {
                observer.Update(Temperature, Humidity, Pressure);
            }
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {

            if(observers.IndexOf(o) >= 0)
            {
                observers.Remove(o);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObserver();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.Temperature = temperature;
            this.Humidity = humidity;
            this.Pressure = pressure;
            MeasurementsChanged();
        }
    }
}
