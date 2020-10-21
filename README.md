# Details of repository 

Complete project from Creatng API, writing test cases, connecting to DB and some DB Queries.

- **Compress Folder:** It has all the details of ABTest, .Net Core API and DB context.
- **React folder:** It has integration of API with a React component.
- **TestQuery.sql:** It has all the queries asked.

# Problem Statement

Compression Details 
If you have an input data say example AAABBCCCDAAF which is in uncompressed format, we need to compress the same using the below rules


You must identify the number of times each character is repeated continuously and append the character with the number of times 
it is repeated.Eg., Initially A is repeated thrice, hence it would be represented as A3. 
Next, B is repeated twice, hence it would be represented as B2.
Similarly, for C it is C3 and D it is D1Though A was already compressed, 
this second instance of A is considered as new Instance and represented as A2 followed by F1. Hence the compressed value for AAABBCCCDAAF 
would be A3B2C3D1A2F1


-> GetCompressedString
-> StoreCompressedString
-> GetAllCompressedStrings


Database=CompressedAPIContext-11f47313-7037-481c-bd3a-a4060b371f81;

https://localhost:44357/api/DataModels

https://localhost:44357/api/DataModels/GetCompressedString/AAABBCCCDAAF
