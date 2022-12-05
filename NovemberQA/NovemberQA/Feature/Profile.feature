Feature: Profile

As a seller
I want the feature to add my Profile details
So that the people seeking for skills can look into my details

@languages
Scenario Outline: Add Languages in the Profile
    Given I logged into portal successfully
	When I add '<Languages>' and '<Level>' to the profile
	Then The '<Languages>' and '<Level>' should be added successfully

    
Examples:
| Languages | Level             |
| Arabic    | Basic             |
| English   | Fluent            |
| Hindi     | Conversational    |      

@skills
Scenario Outline: Add Skills in the Profile
	Given I logged in portal successfully
	When I add '<Skills>' and '<Level>' to profile
	Then The '<Skills>' and '<Level>' should be added to the profile successfully

Examples:
| Skills   | Level    |
| Cooking  | Expert   |


@certifications
Scenario Outline: Add Certifications in the Profile
    Given I logged to portal successfully
	When I add '<Certification>', '<From>' and '<Year>' to profile
	Then The '<Certification>', '<From>' and '<Year>' should be added to the profile successfully

Examples: 
| Certification |  From              | Year |
| Test Analyst  |  Industry Connect  | 2022 |
