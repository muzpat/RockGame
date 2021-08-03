using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoleIn = new ConsoleWrapper();
            RockPaperScissors theGame = new RockPaperScissors();
            string winner = theGame.BestOfThree(consoleIn);
            Console.WriteLine("GAME OVER: " + winner);

            Console.WriteLine("Press ENTER to exit");
            Console.ReadLine();
        }
    }

    public interface IConsole
    {
        string ReadLine();
    }

    public class ConsoleWrapper : IConsole
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
