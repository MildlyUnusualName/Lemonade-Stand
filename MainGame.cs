namespace Lemonade_Stand_Code
{
    class MainGame
    {
        public static void RunGame()
        {
            Player player1 = new Player(Player.NewName(), Player.NewNumDays());
            Inventory.PrintInventory(player1);
            Store.BuyCups(25, player1);
            Inventory.PrintInventory(player1);

        }

    }
}