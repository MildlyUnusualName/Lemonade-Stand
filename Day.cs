using System;
using System.Collections.Generic;

namespace Lemonade_Stand_Code{

    public class Day
    {
        List<Customer> customersForDay;
        Weather weatherOfDay = new Weather(0, null);
        Random random = new Random();
        static Recipe playerRecipe = new Recipe(0, 0, 0, 0);
        int cupsInPitcher;

        public Day(Player player)
        {
            string temp = WeatherOfDay.ForecastOptions[random.Next(0, 3)];
            WeatherOfDay = new Weather(random.Next(60, 90), temp);
            customersForDay = new List<Customer>();

            UI.DisplayWeather(weatherOfDay);
            UI.MainMenu(player);
            UI.NewRecipe(PlayerRecipe);
            UI.PrintRecipe(PlayerRecipe);

            UI.DisplayWeather(weatherOfDay);


            CupsInPitcher = Inventory.MakePitcher(PlayerRecipe, player.Inventory);
            Console.WriteLine("Cups in pitcher: " + CupsInPitcher);
            Customer.CreateCustomers(WeatherOfDay.Temperature, WeatherOfDay.Forecast, customersForDay);

            int j = 0;
            foreach(Customer cust in customersForDay)
            {

                if (CupsInPitcher == 0)
                {
                    
                    
                        CupsInPitcher = Inventory.MakePitcher(PlayerRecipe, player.Inventory);
                    
                }
                else
                {
                    Console.WriteLine($"Cups remaing in pitcher {CupsInPitcher}");
                    CupsInPitcher -= Customer.CustomerBuysCup(player, player.Inventory, PlayerRecipe, cust, j);
                }
                
                j++;

            }

            Console.WriteLine($"Customers today: {customersForDay.Count}");

            
            Console.WriteLine("The remainder of your ice melted at the end of the day.");
            player.Inventory.Ice = 0;
            CupsInPitcher = 0;

        }

        public List<Customer> CustomersForDay { get => customersForDay; set => customersForDay = value; }
        public static Recipe PlayerRecipe { get => playerRecipe; set => playerRecipe = value; }
        public Weather WeatherOfDay { get => weatherOfDay; set => weatherOfDay = value; }
        public int CupsInPitcher { get => cupsInPitcher; set => cupsInPitcher = value; }
    }
}