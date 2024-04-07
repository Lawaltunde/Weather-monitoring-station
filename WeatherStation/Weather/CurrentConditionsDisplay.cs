namespace WeatherStation.Weather;
using Weather.Interfaces;

public class CurrentConditionsDisplay : IDisplay<string>
{
    private double output;
    private DateTime dateTime = new DateTime();
    public  void Display(string param){
        Console.WriteLine("Date: "+ dateTime.Date);
        Console.WriteLine("Time: "+ dateTime.TimeOfDay);

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
            default:
                throw new Exception("wrong value inserted");
        };
        }

    }

}