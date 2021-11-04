using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7ListRPGDemo
{
    class Program
    {
        static void Main()
        {
            //create an instant of the game class so we can play
            Game myGame1 = new Game();

            //populate the array
            myGame1.PopulateContentArray();

            myGame1.FirstScenario();

            myGame1.SecondScenario();
        }
    }
}