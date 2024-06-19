Feature: Feature1

A short summary of the feature


Scenario Outline: Automation new Request
	Given I created new Request <id> '<title>' and <UserId>
	And I Get the Data with <id>
	And I Deleted the Request  Request <id> '<title>' and <UserId>

	Examples: 
	| id | title | UserId |
	| 12 | Harrypotter | 101    |