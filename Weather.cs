namespace Lemonade_Stand_Code
{
    public class Weather
    {
        static string[] forecastOptions = { "Cloudy", "Sunny", "Hazy", "Rainy" };
        int temperature;
        string forecast;

        public Weather(int temperature, string forecast)
        {
            this.temperature = temperature;
            this.forecast = forecast;
        }

        public int Temperature { get => temperature; set => temperature = value; }
        public string Forecast { get => forecast; set => forecast = value; }
        public string[] ForecastOptions { get => forecastOptions; set => forecastOptions = value; }

    }
}