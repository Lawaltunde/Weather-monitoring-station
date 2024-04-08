namespace WeatherStation.Weather;

using System.Collections;
using Weather.Interfaces;

/// <summary>
/// This is the subject of the Observer pattern and also a Singleton. It collects weather data from a weather station (for simplicity, you can simulate this by randomly generating data). When the data changes, it notifies all observers.
/// </summary>
/// <typeparam name="T">Any type</typeparam>


public class WeatherData<T>
{
    private T? _value;
    IList<IDisplay<T>> subscribers = new List<IDisplay<T>>();

    public T? Value{
        get{
            return _value;
        }

        set{
            _value = value;
            Notify(value);
        }
    }

    public void Subscribe(IDisplay<T> subscriber){
         if(!subscribers.Contains(subscriber))
             subscribers.Add(subscriber);
    }

    public void UnSubscribe(IDisplay<T> subscriber){
         if(subscribers.Contains(subscriber))
             subscribers.Remove(subscriber);
    }

    private void Notify(T? message){
        foreach(var sub in subscribers){
            sub.Display(message);
        }
    }

}
