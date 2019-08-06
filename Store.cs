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

        public static double BuyCups(int numCups)
        {
            if (numCups == 25)
            {
                return cups25;
            }
            else if (numCups == 50)
            {
                return cups50;
            }
            else if (numCups == 100)
            {
                return cups100;
            }
            else
            {
                System.Console.WriteLine("That is not a valid amount of cups");
                BuyCups(int.Parse(System.Console.ReadLine()));
                return 0;
            }
            
        }

       
    }
}