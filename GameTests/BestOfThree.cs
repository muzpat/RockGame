using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
namespace GameTests
{

    [TestClass]
    public class BestOfThree
    {

        [TestMethod]
        public void BestOfThree1()
        {
            var consoleIn = new GameTests.ConsoleWrapper2();
            RockGame.RockPaperScissors theGame = new RockGame.RockPaperScissors();
            string result = theGame.BestOfThree(consoleIn);
            Debug.WriteLine("result : " + result);
            string[] possible = { "You Won!", "The Machine Won!" };
            CollectionAssert.Contains(possible, result);
        }
    }
}

