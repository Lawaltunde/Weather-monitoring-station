using WeatherStation.Weather;

var weatherData = new WeatherData<string>();
Console.WriteLine("Please enter your command (CurrentConditionsDisplay, StatisticsDisplay, ForecastDisplay: ");

    var obs1 = Console.ReadLine()?? "";
    weatherData.Subscribe(WeatherStation_.CreateDisplay(obs1));
Console.WriteLine("Enter temperature (This must be a figure): ");
    weatherData.Value = Console.ReadLine()?? "";
    //weatherData.Subscribe(obs1);


