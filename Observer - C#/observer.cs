namespace Weather.Observer
{
    using System.Collections.Generic;

    public abstract class WeatherSubject
    {
        #region Fields

        private List<IWeatherObserver> observers = new List<IWeatherObserver>();

        #endregion Fields

        #region Methods

        public void NotifyObservers(WeatherData data)
        {
            foreach (var weatherObserver in observers)
            {
                weatherObserver.Update(data);
            }
        }

        public void RegisterObserver(IWeatherObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IWeatherObserver o)
        {
            if (observers.Contains(o))
                observers.Remove(o);
        }

        #endregion Methods
    }
}