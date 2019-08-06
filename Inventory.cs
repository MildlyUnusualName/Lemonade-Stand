namespace Lemonade_Stand_Code{

    public class Inventory
    {
        int cups;
        int lemons;
        int sugar;
        int ice;

        public Inventory()
        {
            cups = 0;
            lemons = 0;
            sugar = 0;
            ice = 0;
        }

        public int Cups { get => cups; set => cups = value; }
        public int Lemons { get => lemons; set => lemons = value; }
        public int Sugar { get => sugar; set => sugar = value; }
        public int Ice { get => ice; set => ice = value; }
    }
}