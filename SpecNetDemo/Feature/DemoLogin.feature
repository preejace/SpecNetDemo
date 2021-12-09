Feature: DemoLogin
	Login to EA Demo application

@smoke
Scenario: Perform login of EA Login Site
	Given I launch the EA Site
	And I click the Login link
	When I enter the following details
		| UserName | Password |
		| admin    | password |
	And I click the Login button
	Then I should be displayed the Employee details link