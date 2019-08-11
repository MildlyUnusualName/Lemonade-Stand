using System;
using System.Collections.Generic;

namespace Lemonade_Stand_Code{

    public class Day
    {
        List<Customer> customersForDay;
        Weather weatherOfDay;
        Random random = new Random();
        

        public Day()
        {
            weatherOfDay = new Weather(random.Next(60, 90), weatherOfDay.ForecastOptions[random.Next(0, 3)]);
            customersForDay = new List<Customer>();

            int numCustomers = random.Next(1, 20);
            for (int i = 0; i <= numCustomers; i++)
            {
                Customer.CreateCustomers(weatherOfDay.Temperature, weatherOfDay.Forecast, customersForDay);
            }
        }

        public List<Customer> CustomersForDay { get => customersForDay; set => customersForDay = value; }
    }
}