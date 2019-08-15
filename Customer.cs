
using System;
using System.Collections.Generic;

namespace Lemonade_Stand_Code{
    public class Customer
    {
        double pricePreference;
        int icePreference;
        int lemonPreference;
        int sugarPreference;
        bool satisfied;

        public Customer(double price, int lemon, int sugar, int ice)
        {
            this.pricePreference = price;
            this.lemonPreference = lemon;
            this.sugarPreference = sugar;
            this.icePreference = ice;
            this.satisfied = false;
        }

        public static double CreateDouble(Random r, double min, double max) //Creates random double value
        {
            return r.NextDouble() * (max - min) + min;
        }

        public bool Satisfied { get => satisfied; set => satisfied = value; } 

        public static void CreateCustomers(int temperature, string forecast, List<Customer> c)
        {
            Random random = new Random();
            Customer cust;

            if (forecast == "Rainy") //Rainy day, less customers out
            {
                int numCustomers = random.Next(1, 10);
                for (int i = 0; i < numCustomers; i++)
                {
                    if (temperature >= 80) //Hot day more ice
                    {
                        cust = new Customer(CreateDouble(random, 0, 1.6), random.Next(0, 6), random.Next(0, 6), random.Next(3, 6));
                        c.Add(cust);
                    }
                    else if (temperature < 80 && temperature > 70) //Mild day more sugar, less ice
                    {
                        cust = new Customer(CreateDouble(random, 0, 1), random.Next(0, 6), random.Next(2, 6), random.Next(0, 4));
                        c.Add(cust);
                    }
                    else if (temperature <= 70) //Cold day more lemons, more sugar, no ice
                    {
                        cust = new Customer(CreateDouble(random, 0, .35), random.Next(3, 6), random.Next(2, 6), random.Next(0, 0));
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
                        cust = new Customer(CreateDouble(random, 0, 2), random.Next(0, 6), random.Next(0, 6), random.Next(3, 6));
                        c.Add(cust);
                    }
                    else if (temperature < 80 && temperature > 70) //Mild day more sugar, less ice
                    {
                        cust = new Customer(CreateDouble(random, 0, 1), random.Next(0, 6), random.Next(2, 6), random.Next(0, 4));
                        c.Add(cust);
                    }
                    else if (temperature <= 70) //Cold day more lemons, more sugar, no ice
                    {
                        cust = new Customer(CreateDouble(random, 0, .75), random.Next(3, 6), random.Next(2, 6), random.Next(0, 0));
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
                        cust = new Customer(CreateDouble(random, 0, 1.5), random.Next(0, 6), random.Next(0, 6), random.Next(3, 8));
                        c.Add(cust);
                    }
                    else if (temperature < 80 && temperature > 70) //Mild day more sugar, less ice
                    {
                        cust = new Customer(CreateDouble(random, 0, 1.2), random.Next(0, 6), random.Next(2, 6), random.Next(0, 4));
                        c.Add(cust);
                    }
                    else if (temperature <= 70) //Cold day more lemons, more sugar, no ice
                    {
                        cust = new Customer(CreateDouble(random, 0, .5), random.Next(3, 6), random.Next(2, 6), random.Next(0, 0));
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
                        cust = new Customer(CreateDouble(random, 0, 2.5), random.Next(0, 6), random.Next(0, 6), random.Next(3, 10));
                        c.Add(cust);
                    }
                    else if (temperature < 80 && temperature > 70) //Mild day more sugar, less ice
                    {
                        cust = new Customer(CreateDouble(random, 0, 1.6), random.Next(0, 6), random.Next(2, 6), random.Next(0, 4));
                        c.Add(cust);
                    }
                    else if (temperature <= 70) //Cold day more lemons, more sugar, no ice
                    {
                        cust = new Customer(CreateDouble(random, 0, .8), random.Next(3, 6), random.Next(2, 6), random.Next(0, 0));
                        c.Add(cust);
                    }
                }
            }

            
            


        }

        public static int CustomerBuysCup(Player p, Inventory i, Recipe r, Customer c, int count)
        {
            i.Cups -= 1;
            p.Munny += r.PricePerPitcher;
            int sour = 0;
            int pricey = 0;
            int sweet = 0;
            int cold = 0;


            if (c.lemonPreference < r.LemonPerPitcher || c.lemonPreference > r.LemonPerPitcher)
            {
                sour = 1;
            }
            if (c.sugarPreference < r.SugarPerPitcher || c.sugarPreference > r.SugarPerPitcher)
            {
                sweet = 1;
            }
            if (c.icePreference < r.IcePerPitcher || c.icePreference > r.IcePerPitcher)
            {
                cold = 1;
            }
            if (c.pricePreference < r.PricePerPitcher || c.pricePreference > r.PricePerPitcher)
            {
                pricey = 1;
            }

            if (sour + pricey + sweet + cold <= 2)
            {
                Console.WriteLine($"Customer {count+1} was satisfied overall.");
                c.Satisfied = true;
            }
            else
            {
                Console.WriteLine($"Customer {count+1} was disatisfied.");
                c.satisfied = false;
            }
            return 1;
        }
    }
}