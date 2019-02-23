Feature: SpecFlowFeature2
	In order to update my profile
	As a skilled trader
	I want to add the skills that I know

@mytag
Scenario: Check if user is able to add a skill
	Given I have clicked on the Skills tab under the Profile page
	When I add a new skill
	Then that skill should be displayed on my listings
