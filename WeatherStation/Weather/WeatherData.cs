namespace WeatherStation.Weather;

using System.Collections;
using WeatherStation.Weather.Interfaces;


public class WeatherData<T>
{
    IList<IDisplay<T>> subscribers = [];

    public void Subscribe(IDisplay<T> subscriber){
         if(!subscribers.Contains(subscriber))
             subscribers.Add(subscriber);
    }

    public void UnSubscribe(IDisplay<T> subscriber){
         if(subscribers.Contains(subscriber))
             subscribers.Remove(subscriber);
    }

}
