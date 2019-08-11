namespace Lemonade_Stand_Code
{
    public class Weather
    {
        string[] forecastOptions = { "Cloudy", "Sunny", "Hazy", "Rainy" };
        int temperature;
        string forecast;

        public Weather(int temper, string forecast)
        {
            this.temperature = temper;
            this.forecast = forecast;
        }

        public int Temperature { get => temperature; set => temperature = value; }
        public string Forecast { get => forecast; set => forecast = value; }
        public string[] ForecastOptions { get => forecastOptions; set => forecastOptions = value; }

    }
}