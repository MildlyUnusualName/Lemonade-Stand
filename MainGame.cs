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

            

            for (int i = 1; i <= dayCount; i++)
            {

                Console.WriteLine();
                Console.WriteLine("Day " + i + "!");
                Day _newDay = new Day(player1);

                if (_newDay.CupsInPitcher == -1)
                {
                    return;
                }

                dayOfGame.Add(_newDay);

            };

            Console.WriteLine($"Your final dollar amount is {player1.Munny} which equals a total profit of {player1.Munny - 20}");
            
            
        }

    }
}