Feature:Login to gmail and then Logout from gmail


@mytag
Scenario: Login and Logout from gmail
	Given Open the gmail login page
	When I Login with valid Credential
	Then I should click on Sign out Button
	And I should be successfully logout from gmail
