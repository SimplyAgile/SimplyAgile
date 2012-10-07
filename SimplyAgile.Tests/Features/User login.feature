@login
Feature: User login
	In order to access the software and keep the data secure
	As an existing user
	I want to be able to login

Scenario: Existing user can login
	Given My account is in good standing
	And I have allowed my openAuth provider to share my information with SimplyAgile
	When I login without requesting a page 
	Then I should be directed to my dashboard

Scenario: Existing user can login and access a requested page
	Given My account is in good standing
	And I have allowed my openAuth provider to share my information with SimplyAgile
	When I visit a page that requires authorization 
	Then I should be directed to the correct page

Scenario: Existing user can not login because of an account issue
	Given I have allowed my openAuth provider to share my information with SimplyAgile
	And My account is not in good standing
	When I visit a page that requires authorization 
	Then I must be sent to the account support page

Scenario: Existing user can not login because of an openId issue or they are not logged in.	
	Given I have not allowed my openAuth provider to share my information with SimplyAgile
	When I visit a page that requires authorization 
	Then I must be sent to the login page