namespace WeatherStation.Weather;
using Weather.Interfaces;

public class CurrentConditionsDisplay : IDisplay<string>
{
    private DateTime dateTime = new DateTime();
    public  void Display(string parameter){
        Console.WriteLine("Date: "+ dateTime.Date);
        Console.WriteLine("Time: "+ dateTime.TimeOfDay);

        double val = double.Parse(parameter);

        switch(val){
            case <= -20.0: 
                Console.WriteLine("{0}°C: Extreme Cold", parameter);
                break;

            case <= -5.0: 
                 Console.WriteLine("{0}°C: Cold", parameter);
                 break;
            case <= 10.0: 
                 Console.WriteLine("{0}°C: Cool", parameter);
                 break;
            case <= 25.0: 
                 Console.WriteLine("{0}°C: Mild", parameter);
                 break;

            case <=35.0: 
                 Console.WriteLine("{0}°C: Walm", parameter);
                 break;
            default:
                throw new Exception("wrong value inserted");
        };

    }

}