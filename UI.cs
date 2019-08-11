using System;
namespace Lemonade_Stand_Code{

    public static class UI //User Interface. Filled with all the good UI based helper methods.
    {
        public static void PrintInventory(Player p)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("You have $" + p.Munny);
            System.Console.WriteLine("Your inventory consists of:    " + p.Inventory.Cups + " cups    " + p.Inventory.Lemons + " lemons    " + p.Inventory.Sugar + " sugar    " + p.Inventory.Ice + " ice    ");

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
            Console.WriteLine("21 days");
            days = int.Parse(Console.ReadLine());


            if (days == 7 || days == 14 || days == 21)
            {
                return days;
            }
            else
            {
                Console.WriteLine("That is not a valid amount of days, let's start over.");
                NewNumDays();
                return days;

            }
        }

        public static void NewRecipe(Recipe r)
        {
            Console.WriteLine("Let's build your recipe!");
            Console.WriteLine();
            Console.WriteLine("Please set your price per cup ($x.xx): ");
            r.PricePerCup = double.Parse(Console.ReadLine());
            Console.WriteLine("Please set your lemons per cup: ");
            r.LemonPerCup = int.Parse(Console.ReadLine());
            Console.WriteLine("Please set your sugar per cup: ");
            r.SugarPerCup = int.Parse(Console.ReadLine());
            Console.WriteLine("Please set your ice per cup: ");
            r.IcePerCup = int.Parse(Console.ReadLine());

            Console.WriteLine("Recipe: ");
            Console.WriteLine("Cup Price |" + r.PricePerCup);
            Console.WriteLine("Lemons    |" + r.LemonPerCup);
            Console.WriteLine("Sugar     |" + r.SugarPerCup);
            Console.WriteLine("Ice       |" + r.IcePerCup);
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
                UI.MainMenu(p);
            }
            else if (option == 2)
            {
                Store.BuyLemons(UI.StoreLemons(p), p);
                UI.MainMenu(p);
            }
            else if (option == 3)
            {
                Store.BuySugar(UI.StoreSugar(p), p);
                UI.MainMenu(p);
            }
            else if (option == 4)
            {
                Store.BuyIce(UI.StoreIce(p), p);
                UI.MainMenu(p);
            }
            else
            {
                //Continue with Game
            }

        }

        public static int StoreCups(Player p) 
        {
            int choice = 0;
            Console.WriteLine("You have " + p.Inventory.Cups + " Cups and $" + p.Munny + " remaining."); 
            Console.WriteLine();
            Console.WriteLine("How many cups would you like to buy? Enter 0 to return.");
            Console.WriteLine();
            Console.WriteLine("25 cups = $.84");
            Console.WriteLine("50 cups = $1.67");
            Console.WriteLine("100 cups = $3.20");
            choice = int.Parse(Console.ReadLine());
            //return choice
            if (choice == 0)
            {
                UI.MainMenu(p);
            }
            else if (choice == 25 || choice == 50 || choice == 100)
            {
                return choice;
            }
            else
            {
                Console.WriteLine("That is not a valid amount of cups.");
                UI.StoreCups(p);
            }
            return 0;
        }

        public static int StoreLemons(Player p)
        {
            int choice = 0;
            Console.WriteLine("You have " + p.Inventory.Lemons + " Lemons and $" + p.Munny + " remaining.");
            Console.WriteLine();
            Console.WriteLine("How many lemons would you like to buy? Enter 0 to return.");
            Console.WriteLine();
            Console.WriteLine("10 lemons = $.53");
            Console.WriteLine("30 lemons = $2.13");
            Console.WriteLine("75 lemons = $4.24");
            choice = int.Parse(Console.ReadLine());
            //return choice
            if (choice == 0)
            {
                UI.MainMenu(p);
            }
            else if (choice == 10 || choice == 30 || choice == 75)
            {
                return choice;
            }
            else
            {
                Console.WriteLine("That is not a valid amount of lemons.");
                UI.StoreLemons(p);
            }
            return 0;
        }

        public static int StoreSugar(Player p)
        {
            int choice = 0;
            Console.WriteLine("You have " + p.Inventory.Sugar + " Sugar and $" + p.Munny + " remaining.");
            Console.WriteLine();
            Console.WriteLine("How much sugar would you like to buy? Enter 0 to return.");
            Console.WriteLine();
            Console.WriteLine("8 sugar = $.51");
            Console.WriteLine("20 sugar = $1.55");
            Console.WriteLine("48 sugar = $3.42");
            choice = int.Parse(Console.ReadLine());
            //return choice
            if (choice == 0)
            {
                UI.MainMenu(p);
            }
            else if (choice == 8 || choice == 20 || choice == 48)
            {
                return choice;
            }
            else
            {
                Console.WriteLine("That is not a valid amount of sugar.");
                UI.StoreSugar(p);
            }
            return 0;
        }

        public static int StoreIce(Player p)
        {
            int choice = 0;
            Console.WriteLine("You have " + p.Inventory.Ice + " Ice and $" + p.Munny + " remaining.");
            Console.WriteLine();
            Console.WriteLine("How much ice would you like to buy? Enter 0 to return.");
            Console.WriteLine();
            Console.WriteLine("100 ice = $.93");
            Console.WriteLine("250 ice = $2.13");
            Console.WriteLine("500 ice = $3.73");
            choice = int.Parse(Console.ReadLine());
            //return choice
            if (choice == 0)
            {
                UI.MainMenu(p);
            }
            else if (choice == 100 || choice == 250 || choice == 500)
            {
                return choice;
            }
            else
            {
                Console.WriteLine("That is not a valid amount of ice.");
                UI.StoreIce(p);
            }
            return 0;
            
        }

    }
}