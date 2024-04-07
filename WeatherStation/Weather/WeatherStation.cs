namespace WeatherStation.Weather;
using Weather.Interfaces;
public class WeatherStation
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