Feature:Mars Profile

As a seller
I want the feature to add my profile
So that 
Seller's are able to see the details on the Profile page

Background:
	Given I logged in to Mars portal successfully
	When I navigate to profile page

Scenario Outline:01 Seller is able to add Language details
    Given Add new '<language>' and '<level>' to the profile
	Then '<language>'and '<level>' should be added successfully

	Examples: 
	| Languages | Level  |
	| English   | Fluent |

Scenario Outline: Seller is able to edit Language deatails
	Given Add new '<language>' and '<level>' to the profile
	Then '<language>'and '<level>' should be updated successfully

	Examples: 
	| Languages | Level |
	| French    | Basic |

Scenario: Seller is able to delete Language deatails
	Given Delete the existing Language deatails
	Then  Language deatails should be deleted successfully

Scenario: Verify validation error for Language tab
	Given Left Language Field blank
	Then Error message should be displayed 

Scenario Outline:02 Seller is able to add Skills details
	Given Added new '<Skills>' and '<Level>' to the profile
	Then '<Skills>' and '<Level>' should be added successfully

	Examples: 
	| Skills  | Level    |
	| QA      | Beginner |

Scenario Outline: Seller is able to edit Skills details
	Given Edit existing '<Skills>' and '<Level>' on profile
	Then '<Skills>' and '<Level>' should be updated successfully

	Examples: 
	| Skills       | Level  |
	| Test Analyst | Expert |

	
Scenario:Seller is able to delete Skills details
	Given Delete existing Skills
	Then Skills should be deleted successfully


Scenario:Verify validation error for Skills tab
	Given Left Skills field as blank
	Then Error message should be displayed 

Scenario Outline:03 Seller is able to add Education details
	Given Added new '<Country>''<University>' '<Title>' '<Degree>' and '<Graduation Year>" to the profile
	Then '<Country>''<University>' '<Title>' '<Degree>' and '<Graduation Year>" should be added successfully

	Examples: 
	| Country | University | Title  | Degree     | Graduation Year |
	| USA     | American   | B.Tech | Bachelor's | 2022            |

Scenario Outline: Seller is able to edit Education details
	Given Edit existing '<Country>''<University>' '<Title>' '<Degree>' and '<Graduation Year>" on profile
	Then '<Country>''<University>' '<Title>' '<Degree>' and '<Graduation Year>" should be updated successfully

	Examples: 
	| '<Country | University | Title  | Degree   | Graduation |
	| Australia | Victoria   | M.Tech | Master's | 2023       |

	
Scenario:Seller is able to delete Education details
	Given Delete existing Skills
	Then Skills should be deleted successfully


Scenario:Verify validation error for Education tab
	Given Left Skills field as blank
	Then Error message should be displayed 


Scenario Outline:04 Seller is able to add the Certifications details
	Given Add new '<Certifications>','<CertificateFrom>' and '<Year>' to profile
	Then The '<Certifications>','<CertificateFrom>' and '<Year>'details should be added successfully

	Examples: 
	| Certifications   | CertificateFrom | Year |
	| Istqb Foundation | ISTQB           | 2022 |
	

Scenario Outline: seller is able to edit the Certifications details
	Given Edit existing '<Certifications>','<CertificateFrom>' and '<Year>' to profile
	Then '<Certifications>','<CertificateFrom>' and '<Year>' details should be updated successfully

	Examples: 
	| Certifications | CertificateFrom | Year |
	| Istqb Advance  | ISTQB           | 2023 |

Scenario: Seller is able to delete Certifications details
	Given Delete Certifications details
	Then Certifications details should be deleted successfully

Scenario: Verify validation error for Certifications tab
	Given Left Certifications field as blank
	Then Following error message should be displayed

Scenario:05 Seller is able to add description on profile
Given I provide the description as "My name is Mohana,i would love to work in IT field."
	Then The description details should be added successfully

Scenario:Seller is able to edit description on the Profile
	Given Edit the description as "Hi, i would love to listen music and do dancing during free times."
	Then The description details should be added successfully

Scenario:Seller is unable to save when the description is empty on the Profile
	Given Delete the description and save
	Then Error message (Please, a description is required) should be displayed

Scenario Outline:Verify validation error for Description field 
	Given Enter special characters or leave the Description box blank
 	Then Following error messages should be displayed

	Examples: 
	| Description | Popup Error message                          |
	| *&          | First character can only be digit or letters |
	|             | "Please, a description is required"          |


Scenario Outline:06 Seller is able to add the Availability on profile 
	Given Add '<Availability>','<Hours>' and '<Earn Target>' to profile details
	Then '<Availability>','<Hours>' and '<Earn Target>' should be added successfully

	Examples: 
	| Availability | Hours         | Earn Target                      |
	| Part Time    | As needed     | Between $500 and $1000 per month |


Scenario Outline: Seller is able to edit the Availability on profile 
	Given Edit '<Availability>','<Hours>' and '<Earn Target>' to profile details
	Then '<Availability>','<Hours>' and '<Earn Target>' should be added successfully

	Examples: 
	| Availability | Hours                    | Earn Target               |
	| Full Time    | More than 30hours a week | More than $1000 per month |








