using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace GameTests
{
    [TestClass]
    public class AutoResponse
    {
        [TestMethod]
        public void AutoResponse1()
        {
            var consoleIn = new GameTests.ConsoleWrapper2();
            RockGame.RockPaperScissors theGame = new RockGame.RockPaperScissors();
            string result = theGame.AutoResponse();
            Debug.WriteLine("result : " + result);
            string[] possible = { "P", "R", "S" };
            CollectionAssert.Contains(possible, result);
        }
    }
}
