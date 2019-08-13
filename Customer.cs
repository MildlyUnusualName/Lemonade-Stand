
using System;
using System.Collections.Generic;

namespace Lemonade_Stand_Code{
    public class Customer
    {
        int icePreference;
        int lemonPreference;
        int sugarPreference;
        bool satisfied;

        public Customer(int lemon, int sugar, int ice)
        {
            this.lemonPreference = lemon;
            this.sugarPreference = sugar;
            this.icePreference = ice;
            this.satisfied = false;
        }

        public bool Satisfied { get => satisfied; set => satisfied = value; }

        public static void CreateCustomers(int temperature, string forecast, List<Customer> c)
        {
            Random random = new Random();
            Customer cust;

            Console.WriteLine("You still need to add customer price preference, they should be willing to pay more if it's hotter");
            if (forecast == "Rainy") //Rainy day, less customers out
            {
                int numCustomers = random.Next(1, 10);
                for (int i = 0; i < numCustomers; i++)
                {
                    if (temperature >= 80) //Hot day more ice
                    {
                        cust = new Customer(random.Next(0, 6), random.Next(0, 6), random.Next(3, 6));
                        c.Add(cust);
                    }
                    else if (temperature < 80 && temperature > 70) //Mild day more sugar, less ice
                    {
                        cust = new Customer(random.Next(0, 6), random.Next(2, 6), random.Next(0, 4));
                        c.Add(cust);
                    }
                    else if (temperature <= 70) //Cold day more lemons, more sugar, no ice
                    {
                        cust = new Customer(random.Next(3, 6), random.Next(2, 6), random.Next(0, 0));
                        c.Add(cust);
                    }
                }
            }
            else if (forecast == "Hazy")
            {
                int numCustomers = random.Next(1, 15);
                for (int i = 0; i < numCustomers; i++)
                {
                    if (temperature >= 80) //Hot day more ice
                    {
                        cust = new Customer(random.Next(0, 6), random.Next(0, 6), random.Next(3, 6));
                        c.Add(cust);
                    }
                    else if (temperature < 80 && temperature > 70) //Mild day more sugar, less ice
                    {
                        cust = new Customer(random.Next(0, 6), random.Next(2, 6), random.Next(0, 4));
                        c.Add(cust);
                    }
                    else if (temperature <= 70) //Cold day more lemons, more sugar, no ice
                    {
                        cust = new Customer(random.Next(3, 6), random.Next(2, 6), random.Next(0, 0));
                        c.Add(cust);
                    }
                }
            }
            else if (forecast == "Cloudy")
            {
                int numCustomers = random.Next(1, 15);
                for (int i = 0; i < numCustomers; i++)
                {
                    if (temperature >= 80) //Hot day more ice
                    {
                        cust = new Customer(random.Next(0, 6), random.Next(0, 6), random.Next(3, 6));
                        c.Add(cust);
                    }
                    else if (temperature < 80 && temperature > 70) //Mild day more sugar, less ice
                    {
                        cust = new Customer(random.Next(0, 6), random.Next(2, 6), random.Next(0, 4));
                        c.Add(cust);
                    }
                    else if (temperature <= 70) //Cold day more lemons, more sugar, no ice
                    {
                        cust = new Customer(random.Next(3, 6), random.Next(2, 6), random.Next(0, 0));
                        c.Add(cust);
                    }
                }
            }
            else if (forecast == "Sunny")
            {
                int numCustomers = random.Next(1, 25);
                for (int i = 0; i < numCustomers; i++)
                {
                    if (temperature >= 80) //Hot day more ice
                    {
                        cust = new Customer(random.Next(0, 6), random.Next(0, 6), random.Next(3, 6));
                        c.Add(cust);
                    }
                    else if (temperature < 80 && temperature > 70) //Mild day more sugar, less ice
                    {
                        cust = new Customer(random.Next(0, 6), random.Next(2, 6), random.Next(0, 4));
                        c.Add(cust);
                    }
                    else if (temperature <= 70) //Cold day more lemons, more sugar, no ice
                    {
                        cust = new Customer(random.Next(3, 6), random.Next(2, 6), random.Next(0, 0));
                        c.Add(cust);
                    }
                }
            }

            
            


        }
    }
}