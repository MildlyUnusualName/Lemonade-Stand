using System;
using System.Collections.Generic;
using System.Text;

namespace Lemonade_Stand_Code
{
    public class Recipe
    {
        private double pricePerPitcher;
        private int lemonPerPitcher;
        private int sugarPerPitcher;
        private int icePerPitcher;

        public Recipe(double price, int lemon, int sugar, int ice)
        {
            this.PricePerPitcher = price;
            this.lemonPerPitcher = lemon;
            this.sugarPerPitcher = sugar;
            this.icePerPitcher = ice;

        }

        public double PricePerPitcher { get => pricePerPitcher; set => pricePerPitcher = value; }
        public int LemonPerPitcher { get => lemonPerPitcher; set => lemonPerPitcher = value; }
        public int SugarPerPitcher { get => sugarPerPitcher; set => sugarPerPitcher = value; }
        public int IcePerPitcher { get => icePerPitcher; set => icePerPitcher = value; }
    }

}
