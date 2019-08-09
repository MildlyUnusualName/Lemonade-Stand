using System;
namespace Lemonade_Stand_Code{

    public static class UI //User Interface. Filled with all the good UI based helper methods.
    {
        public static void PrintInventory(Player p)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("You have $" + p.Munny);
            System.Console.WriteLine("Your inventory consists of:    " + p.Inventory.Cups + " cups    " + p.Inventory.Lemons + " lemons    " + p.Inventory.Sugar + " sugar    " + p.Inventory.Ice + " ice    ");
            
           /* System.Console.WriteLine("You have " + );
            System.Console.WriteLine();
            System.Console.WriteLine("You have " + );
            System.Console.WriteLine();
            System.Console.WriteLine("You have " + ;*/
        }

        public static string NewName()
        {
            string tempName = null;

            Console.WriteLine("Welcome to Lemonade Stand. What will your name be?");
            tempName = Console.ReadLine();

            return tempName;
        }

        public static int NewNumDays()
        {
            int days = 0;
            Console.WriteLine("How many days would you like to play for?");
            Console.WriteLine("7 days");
            Console.WriteLine("14 days");
            days = int.Parse(Console.ReadLine());


            if (days == 7)
            {
                return days;
            }
            else if (days == 14)
            {
                return days;
            }
            else
            {
                Console.WriteLine("Something went wrong, let's start over.");
                NewNumDays();
                return days;

            }
        }

        public static void NewRecipe(Recipe r)
        {
            Console.WriteLine("Let's build your recipe!");
            Console.WriteLine();
            Console.WriteLine("Please set your price per cup: ");
            r.CupPrice = int.Parse(Console.ReadLine());
            Console.WriteLine("Please set your lemons per cup: ");
            r.LemonPerCup = int.Parse(Console.ReadLine());
            Console.WriteLine("Please set your sugar per cup: ");
            r.SugarPerCup = int.Parse(Console.ReadLine());
            Console.WriteLine("Please set your ice per cup: ");
            r.IcePerCup = int.Parse(Console.ReadLine());           
        }

        public static void MainMenu(Player p)
        {
            PrintInventory(p);
            Console.WriteLine();
            Console.WriteLine("Would you like to...");
            Console.WriteLine("         1) Buy more cups");
            Console.WriteLine("         2) Buy more lemons");
            Console.WriteLine("         3) Buy more sugar");
            Console.WriteLine("         4) Buy more ice");
            Console.WriteLine("         ...");
            Console.WriteLine("         0) Bankrupt!");
            Console.WriteLine();
            Console.WriteLine("...Or press any key to continue with the game");
            int option = 20;
            try
            {
                 option = int.Parse(Console.ReadLine());
            }
            catch
            {
                //TODO : Move onto the next stage of the game
            }

            if (option == 1)
            { 
                Store.BuyCups(UI.StoreCups(p), p);
            }

        }

        public static int StoreCups(Player p) //TODO : Finish building out Store purchasing options
        {
            int choice = 0;
            Console.WriteLine("You have " + p.Inventory.Cups + " cups and $" + p.Munny + " remaining.");
            Console.WriteLine();
            Console.WriteLine("How many cups would you like to buy?");
            return choice;
        }
    }
}