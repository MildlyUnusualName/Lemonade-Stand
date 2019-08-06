namespace Lemonade_Stand_Code
{

    class Player
    {
        public double munny;
        private int numDays;
        public Player(int n)
        {
            munny = 20.00;
            numDays = n;
        }

        public double Munny { get => munny; set => munny = value; }
    }

}
