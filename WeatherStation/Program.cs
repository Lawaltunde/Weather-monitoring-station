using WeatherStation.Weather;

var weatherData = new WeatherData<string>();
Console.WriteLine("Please enter your command (CurrentConditionsDisplay, StatisticsDisplay, ForecastDisplay: ");

    var obs1 = Console.ReadLine()?? "";
    weatherData.Subscribe(WeatherStation_.CreateDisplay(obs1));
    weatherData._value = Console.ReadLine()?? "";
    //weatherData.Subscribe(obs1);


