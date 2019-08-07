namespace Lemonade_Stand_Code  
{
    public static class Store
    {
        static double cups25 = .84;
        static double cups50 = 1.67;
        static double cups100 = 3.20;

        static double lemons10 = .53;
        static double lemons30 = 2.13;
        static double lemons75 = 4.24;

        static double sugar8 = .51;
        static double sugar20 = 1.66;
        static double sugar48 = 3.42;

        static double ice100 = .93;
        static double ice250 = 2.13;
        static double ice500 = 3.73;

        public static void BuyCups(int numCups, Player p)
        {
            if (numCups == 25)
            {
                p.inventory.Cups += numCups;
                p.munny -= cups25;
            }
            else if (numCups == 50)
            {
                p.inventory.Cups += numCups;
                p.munny -= cups50;
            }
            else if (numCups == 100)
            {
                p.inventory.Cups += numCups;
                p.munny -= cups100;
            }
            else
            {
                System.Console.WriteLine("That is not a valid amount of cups, try again.");
                BuyCups(int.Parse(System.Console.ReadLine()), p);
            }
            
        }

        public static void BuyLemons(int numLemons, Player p)
        {
            if (numLemons == 25)
            {
                p.inventory.Cups += numLemons;
                p.munny -= cups25;
            }
            else if (numLemons == 50)
            {
                p.inventory.Cups += numLemons;
                p.munny -= cups50;
            }
            else if (numLemons == 100)
            {
                p.inventory.Cups += numLemons;
                p.munny -= cups100;
            }
            else
            {
                System.Console.WriteLine("That is not a valid amount of lemons, try again.");
                BuyCups(int.Parse(System.Console.ReadLine()), p);
            }

        }

        public static void BuySugar(int numSugar, Player p)
        {
            if (numSugar == 25)
            {
                p.inventory.Cups += numSugar;
                p.munny -= cups25;
            }
            else if (numSugar == 50)
            {
                p.inventory.Cups += numSugar;
                p.munny -= cups50;
            }
            else if (numSugar == 100)
            {
                p.inventory.Cups += numSugar;
                p.munny -= cups100;
            }
            else
            {
                System.Console.WriteLine("That is not a valid amount of sugar, try again.");
                BuyCups(int.Parse(System.Console.ReadLine()), p);
            }

        }

        public static void BuyIce(int numIce, Player p)
        {
            if (numIce == 25)
            {
                p.inventory.Cups += numIce;
                p.munny -= cups25;
            }
            else if (numIce == 50)
            {
                p.inventory.Cups += numIce;
                p.munny -= cups50;
            }
            else if (numIce == 100)
            {
                p.inventory.Cups += numIce;
                p.munny -= cups100;
            }
            else
            {
                System.Console.WriteLine("That is not a valid amount of ice, try again.");
                BuyCups(int.Parse(System.Console.ReadLine()), p);
            }

        }

    }
}