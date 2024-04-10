using WeatherStation.Weather;

bool isNext = true;
string? holder;
List<string> tempFromUser = new List<string>();

var weatherData = new WeatherData<string>();
Console.WriteLine("Please enter your command (CurrentConditionsDisplay, StatisticsDisplay, ForecastDisplay: ");

    var obs1 = Console.ReadLine()?? "";
    weatherData.Subscribe(WeatherStation_.CreateDisplay(obs1));

    while(isNext){
        
            Console.WriteLine("Enter temperature (This must be a figure): ");
            tempFromUser.Add(Console.ReadLine()?? "");
            Console.WriteLine("Are you adding more Temperature? enter Y or N");
            holder = Console.ReadLine();
            if(holder == "Y" || holder == "y")
                isNext = true;
            else
                isNext = false;
        }

        foreach(var temp in tempFromUser){
            weatherData.Value = temp;
        }
// Console.WriteLine("Enter temperature (This must be a figure): ");
//     weatherData.Value = Console.ReadLine()?? "";
    //weatherData.Subscribe(obs1);


