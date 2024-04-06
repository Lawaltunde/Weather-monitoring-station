namespace WeatherStation.Weather.Interfaces;

public interface IDisplay<T>
{
    void Display(T parameter);
}