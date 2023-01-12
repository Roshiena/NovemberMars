Feature: Language


As a seller
I want to add, edit and delete languages on my Profile
So that people seeking for skills can look into my details


@addlanguages
Scenario Outline: A1 Add Languages in the Profile
    When I add '<Languages>' and '<Level>' to the profile
	Then The '<Languages>' and '<Level>' should be added successfully

    
Examples:
| Languages | Level             |
| Arabic    | Basic             |
| English   | Fluent            |
| Hindi     | Conversational    |      

@editlanguages
Scenario Outline: A2 Edit Languages in the Profile
   When I edit '<Languages>' and '<Level>' to the profile
   Then The '<Languages>' and '<Level>' should be edited successfully

Examples: 
| Languages | Level          |
| French    | Conversational |

@deletelanguages
Scenario: A3 Delete Languages in the Profile
     When I delete Languages and Level from the profile
     Then Languages and Level should be deleted successfully




