Feature: SelectTesting
	
@mytag
Scenario: Get Entity by Id
	When select all from entity where Id = 1
	Then the result should be
	| ProductName		| BrandId	| CategoryId	| ModelYear		| ListPrice		|
	| Trek 820 - 2016	| 9			| 6				| 2016			| 379.99		|


Scenario: Check rows for duplicates
	When select all from entity
	Then Check table rows for duplicates as Trek Checkpoint ALR Frameset - 2019