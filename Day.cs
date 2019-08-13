using System;
using System.Collections.Generic;

namespace Lemonade_Stand_Code{

    public class Day
    {
        List<Customer> customersForDay;
        Weather weatherOfDay = new Weather(0, null);
        Random random = new Random();
        

        public Day()
        {
            string temp = weatherOfDay.ForecastOptions[random.Next(0, 3)];
            weatherOfDay = new Weather(random.Next(60, 90), temp);
            customersForDay = new List<Customer>();

            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Forecast for the day is: " + weatherOfDay.Forecast + "!");
            Console.WriteLine("Maximum temperature for the day is " + weatherOfDay.Temperature + " degrees Fahrenheit.");
            Console.WriteLine();

            Customer.CreateCustomers(weatherOfDay.Temperature, weatherOfDay.Forecast, customersForDay);

                     
            
        }

        public List<Customer> CustomersForDay { get => customersForDay; set => customersForDay = value; }
    }
}