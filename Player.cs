using System;
using System.Collections.Generic;

namespace Lemonade_Stand_Code
{

    public class Player
    {
        private double munny;
        private int numDays;
        private string name;
        private Inventory inventory;
        public Player(string name)
        {
            this.munny = 20.00;
            this.name = name;
            this.inventory = new Inventory();
        }

        public double Munny { get => munny; set => munny = value; }
        public int NumDays { get => numDays; set => numDays = value; }
        public string Name { get => name; set => name = value; }
        public Inventory Inventory { get => inventory; set => inventory = value; }

        

        
    }

}
