using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7ListRPGDemo
{
    public class Game
    {
        //create a content array
        string[] contentArray1 = new string[6];

        //create a list to store inventory
        List<string> inventoryList1 = new List<string>();

        //var to store responses
        string userInput1;
        string userInput2;


        //populate the array
        //create the Game class constructor
      

        public void PopulateContentArray()
        {
            contentArray1[0] = "Would you like to explore... yes or no";
            contentArray1[1] = "No? okay....";
            contentArray1[2] = "In order to open door you need key...type yes or no....";
            contentArray1[3] = "Sorry.... you don't have key";
            contentArray1[4] = "You have open something good luck";
        }
        //Remember for the data normalization because they might type YES or yEs.


        //First scenario
        public void FirstScenario()
        {
            Console.WriteLine(contentArray1[0]);
            userInput1 = Console.ReadLine();

            //conditional branching

            if (userInput1 == "yes")
            {
                Console.WriteLine("You found the red key");
                inventoryList1.Add("red key");
            }
            else
            {
                Console.WriteLine(contentArray1[1]);
            }

            Console.ReadLine();

        }

        public void SecondScenario()
        {
            Console.WriteLine(contentArray1[2]);
            userInput2 = Console.ReadLine();

            //Perform a check to see if you have key
            if (userInput2 == "yes")
            {
                //nest an if/else pair
                if (inventoryList1.Contains("red key"))
                {
                    Console.WriteLine(contentArray1[4]);
                }

                else
                {
                    Console.WriteLine(contentArray1[3]);
                }
            }

            else
            {
                Console.WriteLine(contentArray1[3]);
            }

            Console.ReadLine();
        }


    }
}
