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
            UI.NewRecipe(PlayerRecipe);
            UI.PrintRecipe(PlayerRecipe);

            UI.DisplayWeather(weatherOfDay);


            cupsInPitcher = Inventory.MakePitcher(PlayerRecipe, player.Inventory);
            Console.WriteLine("Cups in pitcher: " + cupsInPitcher);
            Customer.CreateCustomers(WeatherOfDay.Temperature, WeatherOfDay.Forecast, customersForDay);

            int j;
            foreach(Customer cust in customersForDay)
            {
                j = 0;
                if (cupsInPitcher == 0)
                {
                    if (player.Inventory.Lemons == 0 && player.Inventory.Ice == 0 && player.Inventory.Sugar == 0)
                    {
                        Console.WriteLine("You're out of inventory");
                        break;
                    }
                    else
                    {
                        cupsInPitcher -= Inventory.MakePitcher(PlayerRecipe, player.Inventory);
                    }
                }
                Console.WriteLine("Customer ");
                Customer.CustomerBuysCup(player, player.Inventory, PlayerRecipe, cust, j);
                j++;

            }

            Console.WriteLine($"Customers today: {customersForDay.Count}");

            Console.WriteLine("The remainder of your ice melted at the end of the day.");
            player.Inventory.Ice = 0;
            
        }

        public List<Customer> CustomersForDay { get => customersForDay; set => customersForDay = value; }
        public static Recipe PlayerRecipe { get => playerRecipe; set => playerRecipe = value; }
        public Weather WeatherOfDay { get => weatherOfDay; set => weatherOfDay = value; }
    }
}