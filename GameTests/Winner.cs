using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
namespace GameTests
{
    [TestClass]
    public class Winner
    {
        [TestMethod]
        public void Winner1()
        {
            var consoleIn = new GameTests.ConsoleWrapper2();
            RockGame.RockPaperScissors theGame = new RockGame.RockPaperScissors();
            int result = theGame.Winner("R","R");
            Debug.WriteLine("result : " + result);
            int[] possible = { 0,1 };
            CollectionAssert.Contains(possible, result);
        }
    }
}
