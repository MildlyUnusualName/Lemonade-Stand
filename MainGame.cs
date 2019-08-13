using System;
using System.Collections.Generic;

namespace Lemonade_Stand_Code
{
    class MainGame
    {
        public static void RunGame()
        {
            Player player1 = new Player(UI.NewName());
            Recipe recipe1 = new Recipe(0, 0, 0, 0);
            List<Day> dayOfGame = new List<Day>();
            int dayCount = UI.NewNumDays();

            UI.MainMenu(player1);

            for (int i = 1; i <= dayCount; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Day " + i + "!");
                Day _newDay = new Day();
                UI.NewRecipe(recipe1);
                dayOfGame.Add(_newDay);

            };
            
            
            
            
        }

    }
}