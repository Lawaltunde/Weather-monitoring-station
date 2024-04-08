namespace WeatherStation.Weather.Interfaces;
/// <summary>
/// IDisplay is a generic interface that can be implemented by all observer classes. 
/// </summary>
/// <typeparam name="T">Any type is suitable</typeparam>
public interface IDisplay<T>
{
    void Display(T? parameter);
}