Feature: My dashboard
	In order to work of several projects at the same time
	As a logged in user with different roles across prjects
	I want to be able to see a summary of my projects and the current sprint

Background: 
Given I have successfully logged in

Scenario: visiting the dashboard without and projects should guide the user to add one
	Given I do not have any projects
	When I view my dashboard
	Then I should see directions on how to add a project instead of a any projects
