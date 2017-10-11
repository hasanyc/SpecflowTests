Feature:Sign up with invalid email address
	In order to verify email address format
	As a tester
	I should enter email address with less than 6 char values

@mytag
Scenario: Validate the inline error message for email
	Given Open the gmail signup page
	When I enter valid first, last name and invalid email address
	Then I click on Next Step button
	And I should see inline validation message for email
