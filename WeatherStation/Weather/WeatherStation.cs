namespace WeatherStation.Weather;
using Weather.Interfaces;

/// <summary>
///  This is a factory for creating different types of displays.
/// </summary>
public static class WeatherStation_
{
    public static IDisplay<string> CreateDisplay(string command){
        switch(command){
            case "CurrentConditionsDisplay":
                return new CurrentConditionsDisplay();
            
            case "StatisticsDisplay":
                return new StatisticsDisplay();
            case "ForecastDisplay":
                return new ForecastDisplay();
            default:
                throw new ArgumentException("Input any of the following to perform your operation: CurrentConditionsDisplay, StatisticsDisplay, ForecastDisplay");
        }
    }
}