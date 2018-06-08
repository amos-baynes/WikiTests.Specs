Feature: RunSearches
	I want to run some searches on Wikipedia and confirm I get the correct results

@firsttest
Scenario: Find info on honey badger
	Given I have navigated to the Wikipedia home page
	When I search "honey badger"
	Then the "Honey Badger" information page loads

@firstoutline
Scenario Outline: Find info on various search terms
	Given I have navigated to the Wikipedia home page
	When I search <searchTerm>
	Then the <searchResult> information page loads

	Examples: 
	| searchTerm  | searchResult     |
	| taco        | Taco             |
	| Löwen       | Löwen            |
	| नमस्ते        | Namaste          |
	| fighter jet | Fighter Aircraft |