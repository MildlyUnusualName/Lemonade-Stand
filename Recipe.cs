using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade_Stand_Code
{
    public class Recipe
    {
        private double pricePerCup;
        private int lemonPerCup;
        private int sugarPerCup;
        private int icePerCup;

        public Recipe(double price, int lemon, int sugar, int ice)
        {
            this.PricePerCup = price;
            this.lemonPerCup = lemon;
            this.sugarPerCup = sugar;
            this.icePerCup = ice;
        }

        public double PricePerCup { get => pricePerCup; set => pricePerCup = value; }
        public int LemonPerCup { get => lemonPerCup; set => lemonPerCup = value; }
        public int SugarPerCup { get => sugarPerCup; set => sugarPerCup = value; }
        public int IcePerCup { get => icePerCup; set => icePerCup = value; }
    }

}
