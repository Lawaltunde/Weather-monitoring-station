namespace WeatherStation.Weather;
using Weather.Interfaces;

/// <summary>
/// CurrentConditionsDisplay This is one of the observers. It displays the current weather conditions. It’s also a decorator that can add additional information (like date and time) to the display.
/// </summary>

public class CurrentConditionsDisplay : IDisplay<string>
{
    private double output;
    private DateTime dateTime = new DateTime();
    public  void Display(string param){
        Console.WriteLine("========================================");

        Console.WriteLine("Today's Date: "+ dateTime.Date);
        Console.WriteLine("Current Time: "+ dateTime.TimeOfDay);

        if(double.TryParse(param, out output))
        {
            switch(output){
            case <= -20.0: 
                Console.WriteLine("{0}°C: Extreme Cold", output);
                break;

            case <= -5.0: 
                 Console.WriteLine("{0}°C: Cold", output);
                 break;
            case <= 10.0: 
                 Console.WriteLine("{0}°C: Cool", output);
                 break;
            case <= 25.0: 
                 Console.WriteLine("{0}°C: Mild", output);
                 break;

            case <=35.0: 
                 Console.WriteLine("{0}°C: Walm", output);
                 break;
            case <=70.0: 
                 Console.WriteLine("{0}°C: Extremely warm", output);
                 break;
            default:
                throw new Exception("wrong value inserted");
        };
        }

        Console.WriteLine("========================================");
    }

}