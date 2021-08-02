using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
namespace GameTests
{
    public class ConsoleWrapper2 : RockGame.IConsole
    {
        public string ReadLine()
        {
            return "R";
        }
    }
    [TestClass]
    public class HumanPlayerChoose
    {

        [TestMethod]
        public void HumanPlayerChoose1()
        {
            Debug.WriteLine("Starting ... ");
            var consoleIn = new GameTests.ConsoleWrapper2();
            RockGame.RockPaperScissors theGame = new RockGame.RockPaperScissors();
            string result = theGame.HumanPlayerChoose(consoleIn);
            Debug.WriteLine("result : " + result);
            string[] possible = { "P", "R", "S" };
            CollectionAssert.Contains(possible, result);
        }
    }
}