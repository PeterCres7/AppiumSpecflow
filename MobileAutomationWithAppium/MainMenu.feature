@MainMenuTests
Feature: MainMenu
	In order to use the app
	As a user I can interact with the Main menu


Scenario: Add Task
		As a user I want to be able to add tasks

	Given I am in the main menu
	When I tap the add button
	And I add a task
	Then I can see the task displayed
