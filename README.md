# Park Finder | Find Your Park

#### By  Winnie Wang

---


## Technologies Used

* _C#_
* _.NET_
* _HTML_
* _CSS_
* _SQL Workbench_
* _Entity Framework_
* _MVC_
* _Swagger_

---
## Description

This API is designed to provide the name and location of parks. Built with C#/.Net Core, it also uses CRUD and Swagger documentation. 


## Setup and Installation Requirements
**This Setup assumes you have GitBash and MySQL Workbench pre-installed.   
If needed, please navigate to these links:  
https://git-scm.com/download/  
Download Git and follow the setup wizard.  
https://dev.mysql.com/downloads/workbench/  
Download MySQL Workbench, follow the setup wizard & create a localhost server on port 3306**


*Note: Keep track of your username and password, this will be used in the connection link under,*  
"**SQL Workbench Configuration**" > "2. Insert the following code:"


<details>
<summary><strong>Initial Setup</strong></summary>
<ol>
<li>Copy the git repository url: https://github.com/weijwang18/Parks-Lookup
<li>Open a terminal and navigate to your Desktop with <strong>cd</strong> command
<li>Run,   
<strong>$ git clone https://github.com/weijwang18/Parks-Lookup</strong>
<li>In the terminal, navigate into the root directory of the cloned project folder "Parks-Lookup".
<li>Navigate to the projects root directory, "ParkFinder".
<li>Move onto "SQL Workbench Configuration" instructions below to build the necessary database.
<br>
</details>

<details>
<summary><strong>SQL Workbench Configuration</strong></summary>
<ol>
<li>Create an appsetting.json file in the "Factory" directory  
   <pre>Parks-Lookup
   └── ParkFinder
    └── appsetting.json</pre>
<li> Insert the following code: <br>

<pre>{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=park_finder;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}</pre>
<small>*Note: you must include your password in the code block section labeled "YOUR-PASSWORD-HERE".</small><br>
<small>**Note: you must include your username in the code block section labeled "YOUR-USERNAME-HERE".</small><br>
<small>***Note: if you plan to push this cloned project to a public-facing repository, remember to add the appsettings.json file to your .gitignore before doing so.</small>
<li>In root directory of project folder "ParkFinder", run  
<strong>$ dotnet ef migrations add restoreDatabase</strong>
<li>Then run <strong>$ dotnet ef database update</strong>
<ol> 
  <li>Open SQL Workbench.
  <li>Navigate to "park_finder" schema.
  <li>Click the drop down, select "Tables" drop down.
  <li>Verify the tables.
  
</details>
<details>
<summary><strong>To Run</strong></summary>
Navigate to:  
   <pre>Parks-Lookup
   └── <strong>ParkFinder</strong></pre>
Run ```$ dotnet restore``` in the terminal.<br>
Run ```$ dotnet run``` in the terminal to have access to the API in browser.
</details>
<br>
This program was built using *`Microsoft .NET SDK 5.0.401`*, and may not be compatible with other versions. Your milage may vary.

---

## API Documentation

This API uses Swagger for documentation. Swagger is an open-source standardized and language-agnostic interface for designing and documenting REST APIs. To explore the Parks-Lookup API with Swagger, launch the project using dotnet run, and input the following URL into your browser: http://localhost:5000/swagger.

#### HTTP Request
```
GET /api/Parks
POST /api/Parks
GET /api/Parks/{id}
PUT /api/Parks/{id}
DELETE /api/Parks/{id}
```

#### Example Query
```
http://localhost:5000/api/parks/1
```

#### Sample JSON Response
```
{
  "parkId": 1,
  "name": "Yosemite National Park",
  "state": "CA"
}
```

#### Path Parameters

| Parameter | Type | Required/Optional | Description |
| :--- | :--- | :---  | :--- |
| Name | String | Required | Return any park with that name. |
| State | String | Required | Return any park from that state.|

## License

MIT

Copyright (c) 8/2022 Winnie Wang
## Contact Information
_If you have any questions or concerns, please feel free to reach out to me [via email at: Winnie](mailto:weijwang18@gmail.com) or request to make a contribution. Thank you!_ 
