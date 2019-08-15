using System;

namespace Lemonade_Stand_Code{

    public class Inventory
    {
        private int cups;
        private int lemons;
        private int sugar;
        private int ice;

        public Inventory()
        {
            this.cups = 0;
            this.lemons = 0;
            this.sugar = 0;
            this.ice = 0;
        }

        public static int MakePitcher(Recipe r, Inventory i) 
        {
            System.Console.WriteLine("You refilled your pitcher!");
            if (i.Lemons == 0 && i.Ice == 0 && i.Sugar == 0)
            {
                Console.WriteLine("You're out of inventory");
                return -1;
            }
            else
            {
                if ((i.Lemons - r.LemonPerPitcher) < 0)
                {
                    System.Console.WriteLine($"You didn't have enough lemons! You need {r.LemonPerPitcher} and you have {i.Lemons}. This pitcher will have {i.Lemons} lemons.");
                    r.LemonPerPitcher = i.Lemons;
                }
                if ((i.Sugar - r.SugarPerPitcher) < 0)
                {
                    System.Console.WriteLine($"You didn't have enough sugar! You need {r.SugarPerPitcher} and you have {i.Sugar}. This pitcher will have {i.Sugar} sugar");
                    r.SugarPerPitcher = i.Sugar;
                }
                if ((i.Ice - r.IcePerPitcher) < 0)
                {
                    System.Console.WriteLine($"You didn't have enough ice! You need {r.IcePerPitcher} and you have {i.Ice}. This pitcher will have {i.Ice} ice");
                    r.IcePerPitcher = i.Ice;
                }

                i.Lemons -= r.LemonPerPitcher;
                i.Sugar -= r.SugarPerPitcher;
                i.Ice -= r.IcePerPitcher;


                return 12;
            }
            
        }

        public int Cups { get => cups; set => cups = value; }
        public int Lemons { get => lemons; set => lemons = value; }
        public int Sugar { get => sugar; set => sugar = value; }
        public int Ice { get => ice; set => ice = value; }

       
    }
}