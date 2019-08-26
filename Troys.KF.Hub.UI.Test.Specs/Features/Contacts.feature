Feature: Contacts
	As a application user
	I want to be access all contacts within the system
	So I can access and/manipulate contact information productively

@AllContactSearch
Scenario: Contact Search via Side Panel
	Given hub is displayed
	And a count of all active contacts exists
	When I search for all contacts
	Then all active contacts are displayed
