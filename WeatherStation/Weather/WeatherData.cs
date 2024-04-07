namespace WeatherStation.Weather;

using System.Collections;
using Weather.Interfaces;


public class WeatherData<T>
{

    IList<IDisplay<T>> subscribers = new List<IDisplay<T>>();

    public T _value{
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

    private void Notify(T message){
        foreach(var sub in subscribers){
            sub.Display(message);
        }
    }

}
