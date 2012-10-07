@registration

Feature: User Registration
	In order to access the software
	As a new user
	I want to be able to register for an account with my gmail, twitter, facebook, openid
	or any openauth account.

Scenario: A user attempts to visit a secured page with an unregistered openauth account
	Given I have allowed my openAuth provider to share my information with SimplyAgile
	And I have not completed the registration process
	When I visit a page that requires authorization 
	Then I must be sent back into the registration process

