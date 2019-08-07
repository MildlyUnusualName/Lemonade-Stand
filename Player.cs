using System;

namespace Lemonade_Stand_Code
{

    public class Player
    {
        public double munny;
        public int numDays;
        public string name;
        public Inventory inventory;
        public Player(string name, int days)
        {
            this.munny = 20.00;
            this.numDays = days;
            this.name = name;
            this.inventory = new Inventory();
        }

        public double Munny { get => munny; set => munny = value; }

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
    }

}
