Feature: SpecFlowFeature4
	In order to update my profile
	As a skilled trader
	I want to add the certifications that I have
@mytag
Scenario: Check if user is able to add a certification
	Given I have clicked on the Certifications tab under the Profile page
	When I add a new certification
	Then that certification should be displayed on my listings