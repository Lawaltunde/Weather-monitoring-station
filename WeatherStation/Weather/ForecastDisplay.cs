namespace WeatherStation.Weather;
using Weather.Interfaces;

/// <summary>
/// This is yet another observer. It displays a weather forecast based on the current weather data.
/// </summary>
public class ForecastDisplay : IDisplay<string>
{
    private double output;
    public void Display(String param){
        if(double.TryParse(param, out output))
        {
            switch(output){
            case <= -20.0: 
                Console.WriteLine("{0}°C: Rain is promised! ", output);
                break;

            case <= -5.0: 
                 Console.WriteLine("{0}°C: Rain is promised! ", output);
                 break;
            case <= 10.0: 
                 Console.WriteLine("{0}°C: Sunny with partly cloudy! ", output);
                 break;
            case <= 25.0: 
                 Console.WriteLine("{0}°C: Sunny day all week! ", output);
                 break;

            case <=35.0: 
                 Console.WriteLine("{0}°C: Walm! ", output);
                 break;
            default:
                throw new Exception("wrong value inserted");
        };
        }
    }
}