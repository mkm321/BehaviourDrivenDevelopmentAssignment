using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace CricketGame.Specs
{
    [Binding]
    public class PlayerScoreSteps
    {
        private Cricket _game;
        [Given(@"Player has started a game of cricket")]
        [When(@"Player has started a game of cricket")]
        public void WhenPlayerHasStartedAGameOfCricket()
        {
            //ScenarioContext.Current.Pending();
            _game = new Cricket();
        }

        [Given(@"Player has scored (.*) runs")]
        [When(@"Player scores (.*) runs")]
        public void WhenPlayerScoresRuns(int score)
        {
            _game.Score(score);
           // _game.PlayerScore.Should().Be(score);
        }
        
        [Then(@"the player score should be (.*)")]
        public void ThenThePlayerScoreShouldBe(int playerScore)
        {
            _game.PlayerScore.Should().Be(playerScore);
        }
        [Given(@"Player gets out")]
        public void GivenPlayerGetsOut()
        {
            _game.Out = true;
        }


    }
}
