using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class WeatherData:ISubject
    {
        private List<IObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;
        
        public WeatherData()
        {
            observers = new List<IObserver>();
        }
        public void registerObserver(IObserver O)
        {
            observers.Add(O);
        }
        public void removeObserver(IObserver O)
        {
            var i = observers.IndexOf(O);
            observers.RemoveAll(m=>m.Equals(O));
        }
        public void notifyObserver()
        {
            foreach (var item in observers)
            {
                item.update(temperature, humidity, pressure);
            }
        }
        public void measurementsChanged()
        {
            notifyObserver();
        }
        public void setMeasurement(float temperature,float humidity,float pressure)
        {
            this.humidity = humidity;
            this.pressure = pressure;
            this.temperature = temperature;
            measurementsChanged();
        }
    }
}
