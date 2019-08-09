namespace Lemonade_Stand_Code
{
    class MainGame
    {
        public static void RunGame()
        {
            Player player1 = new Player(UI.NewName(), UI.NewNumDays());
            Recipe recipe1 = new Recipe(0,0,0,0);
            UI.MainMenu(player1);
            
        }

    }
}