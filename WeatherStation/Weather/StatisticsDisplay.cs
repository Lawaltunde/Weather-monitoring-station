namespace WeatherStation.Weather;
using Weather.Interfaces;

/// <summary>
/// This is another observer. It displays weather statistics (like average, max, and min temperatures).
/// </summary>



public class StatisticsDisplay : IDisplay<string>
{
    double result;
    IList<double> sumParameters = new List<double>();
    public void Display(string parameter)
    {
        if(double.TryParse(parameter, out result))
            sumParameters.Add(result);
        else
            throw new Exception("String can't be passed to double");
        
        // foreach(var sums in sumParameters){
        //     average += sums;
        //     count++;
        // }

        //average /= count;

        Console.WriteLine("The average temperature is "+ sumParameters.Average());
        Console.WriteLine("The maximum temperature is "+ sumParameters.Max());
        Console.WriteLine("The minimum temperature is "+ sumParameters.Min());

    }
    
}