using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CricketGame;

namespace CricketGameTest
{
    [TestClass]
    public class CricketGameTest
    {
        [TestMethod]
        public void PlayerScore_NewGame_ShouldBeZero()
        {
            var game = new Cricket();
            Assert.IsTrue(game.PlayerScore == 0);
        }
        [TestMethod]
        public void PlayerScore_AfterPlay_ShouldBeFour()
        {
            var game = new Cricket();
            game.Score(4);
            Assert.IsTrue(game.PlayerScore == 4);
        }
        [TestMethod]
        public void PlayerScore_AfterPlay_ShouldNotBeFour()
        {
            var game = new Cricket();
            game.Score(7);
            Assert.IsTrue(game.PlayerScore == 0);
        }
    }
}
