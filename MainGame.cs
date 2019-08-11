using System;
using System.Collections.Generic;

namespace Lemonade_Stand_Code
{
    class MainGame
    {
        public static void RunGame()
        {
            Player player1 = new Player(UI.NewName());
            List<Day> gameDays = new List<Day>();
            int dayCount = UI.NewNumDays();
            for (int i = 0; i <= dayCount; i++)
            {
                //gameDays.Add();
            };
            
            Recipe recipe1 = new Recipe(0,0,0,0);
            UI.MainMenu(player1);
            UI.NewRecipe(recipe1);
        }

    }
}