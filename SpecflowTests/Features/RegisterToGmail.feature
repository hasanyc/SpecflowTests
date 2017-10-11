Feature:Register to gmail account
Sign up should be quick and friendly

@mytag
Scenario: Successful sing up
	Given Open the gmail sign up page
	When I sign up with valid details
	Then I agree the Privacy and Terms
	And I should see a peronalized greeting message
