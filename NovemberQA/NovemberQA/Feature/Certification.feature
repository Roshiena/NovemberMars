Feature: Certification

As a seller
I want the feature to add edit and delete my Cerification details
So that the people seeking for skills can look into my details


@certifications
Scenario Outline: C1 Add Certifications in the Profile
    Given  I have navigated to Certification Page
	When I add '<Certification>', '<From>' and '<Year>' to profile
	Then The '<Certification>', '<From>' and '<Year>' should be added to the profile successfully

Examples: 
| Certification         | From             | Year |
| Test Analyst          | Industry Connect | 2022 |
| Computer Applications | Adobe            | 2015 |

Scenario Outline: C2 Edit Certifications in the Profile
	When I edit '<Certification>', '<From>' and '<Year>' to profile
	Then The '<Certification>', '<From>' and '<Year>' should be edited to the profile successfully

Examples: 
| Certification                        | From            | Year |
| Certificate in Computer Applications | Anna University | 2020 |

Scenario: C3 Delete Certifications in the Profile
	When I delete Certification from the profile
	Then The Certification should be deleted from the profile successfully





