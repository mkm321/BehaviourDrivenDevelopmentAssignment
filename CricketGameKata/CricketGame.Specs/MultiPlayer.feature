Feature: MultiPlayer
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Player1 and Player2 both are playing
	Given Player1 has started playing
	And Player1 has scored 4 runs
	And Player1 gets out
	Given Player2 has started playing
	And Player2 has scored 3 runs
	When Player2 gets out
	Then Player1 Should be the winner

Scenario: Player1 and Player2 both are playing and there is tie
	Given Player1 has started playing
	And Player1 has scored 4 runs
	And Player1 gets out
	Given Player2 has started playing
	And Player2 has scored 4 runs
	When Player2 gets out
	Then There Should be a Tie
