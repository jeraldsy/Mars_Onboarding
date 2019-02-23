Feature: SpecFlowFeature3
	In order to update my Profile
	As a skilled trader
	I want to add my educational background

@mytag
Scenario: Check if user is able to add education
	Given I have clicked on the Education tab under the Profile page
	When I add a new education
	Then that education should be displayed on my listings