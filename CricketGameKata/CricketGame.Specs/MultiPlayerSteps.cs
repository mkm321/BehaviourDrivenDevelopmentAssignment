using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace CricketGame.Specs
{
    [Binding]
    public class MultiPlayerSteps
    {
        private Cricket _player1;
        private Cricket _player2;
        private Cricket _result;
        [Given(@"Player(.*) has started playing")]
        public void GivenPlayerHasStartedPlaying(int p0)
        {
            if (p0 == 1)
            {
                _player1 = new Cricket();
            }
            else
            {
                _player2 = new Cricket();
            }
            //ScenarioContext.Current.Pending();
        }
        
        [Given(@"Player(.*) has scored (.*) runs")]
        public void GivenPlayerHasScoredRuns(int p0, int p1)
        {
            if (p0 == 1)
            {
                _player1.Score(p1);
            }
            else
            {
                _player2.Score(p1);
            }
            //ScenarioContext.Current.Pending();
        }
        
        [Given(@"Player(.*) gets out")]
        public void GivenPlayerGetsOut(int p0)
        {
            if (p0 == 1)
            {
                _player1.Out = true;
            }
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"Player(.*) gets out")]
        public void WhenPlayerGetsOut(int p0)
        {
            if (p0 == 1)
            {
                _player1.Out = true;
            }
            else
            {
                _player2.Out = true;
            }
            if(_player1.Out==true && _player2.Out == true)
            {
                _result = new Cricket();
            }
            if (_player1.PlayerScore > _player2.PlayerScore)
            {
                _result.flag = 1;
            }
            else if(_player2.PlayerScore>_player1.PlayerScore)
            {
                _result.flag = 2;
            }
            else
            {
                _result.flag = 0;
            }
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"Player(.*) Should be the winner")]
        public void ThenPlayerShouldBeTheWinner(int p0)
        {
            _result.flag.Should().Be(p0);
            //ScenarioContext.Current.Pending();
        }
        [Then(@"There Should be a Tie")]
        public void ThenThereShouldBeATie()
        {
            _result.flag.Should().Be(0);
            //ScenarioContext.Current.Pending();
        }

    }
}
