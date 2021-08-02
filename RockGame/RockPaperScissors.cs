using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockGame
{


    public class RockPaperScissors
    {
        public IConsole myConsoleIn;
        public string BestOfThree(IConsole consoleIn)
        {
            myConsoleIn = consoleIn;
            int youWon = 0;
            int machineWon = 0;
            int whosWinning = 0;
            do
            {
                string player = HumanPlayerChoose(myConsoleIn);
                string response = AutoResponse();
                Console.WriteLine("The computer's response was: " + response);
                int thisWinner = Winner(player, response);
                whosWinning = whosWinning + thisWinner;
                if (thisWinner == 0)
                {
                    Console.WriteLine("This was a draw, please play again");
                }
                else if (thisWinner == 1)
                {
                    Console.WriteLine("You won!");
                    youWon++;
                }
                else
                {
                    Console.WriteLine("You lost!");
                    machineWon++;
                }
                Console.WriteLine("You have won: " + youWon + " games. The machine has won: " + machineWon);
            } while (youWon != 2 && machineWon != 2);

            if (youWon == 2)
            {
                return "You Won!";
            }
            else
            {
                return "The Machine Won!";
            }
        }
        public string HumanPlayerChoose(IConsole consoleIn)
        {
            Console.WriteLine("Let's play Rock, Paper, Scissors!");
            Console.WriteLine("Your turn: (R)ock, (P)aper, (S)cissors...");
            // string myGo = Console.ReadLine();
            string myGo = consoleIn.ReadLine();
            return myGo;
        }
        public string AutoResponse()
        {
            var rnd = new Random();
            int dice = rnd.Next(1, 4); // creates a number between 1 and 3
            if (dice == 1)
            {
                return "R";
            }
            else if (dice == 2)
            {
                return "P";

            }
            else
            {
                return "S";
            }
        }
        public int Winner(string human, string machine)
        {
            if ((human == "R") && (machine == "S"))
            {
                Console.WriteLine("human: Rock beats Scissors");
            }
            else if ((human == "S") && (machine == "P"))
            {
                Console.WriteLine("human: Scissors beats paper");
            }
            else if ((human == "P") && (machine == "R"))
            {
                Console.WriteLine("human: Paper beats Rock");
            }

            if ((machine == "R") && (human == "S"))
            {
                Console.WriteLine("machine: Rock beats Scissors");
            }
            else if ((machine == "S") && (human == "P"))
            {
                Console.WriteLine("machine: Scissors beat Paper");
            }
            else if ((machine == "P") && (human == "R"))
            {
                Console.WriteLine("machine: Paper beats Rock");
            }


            if (human == machine)
            {
                return 0;
            }
            else if ((human == "R") && (machine == "S"))
            {
                return 1;
            }
            else if ((human == "S") && (machine == "P"))
            {
                return 1;
            }
            else if ((human == "P") && (machine == "R"))
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
