# .NET CRUD App
Self-hosted (console) CRUD app written in .NET (C#) for RESTful database management with basic authentication.

## Technologies
* ASP.NET Framework Web API (C#)
* MS SQL Server (T-SQL)
* JSON
* Entity Framework 6
* REST API
* Model-View-Controller
* OWIN
* LINQ

## Usage
[Initialize](https://github.com/szymmirr/dotnet-crud-app/blob/main/Initialize.sql) a database in SQL Server and link it in `Web.config` file. Use a REST client of your choice (eg. [Insomnia](https://insomnia.rest/)) to make HTTP requests.

### Add or Update
Add (POST): `http://localhost:49277/company/create`

Update (PUT): `http://localhost:49277/company/update/<company_id>`

```
{
  "Name": "Company",
  "EstablishmentYear": 2000,
  "Employees": [
  {
    "FirstName": "Jan",
    "LastName": "Kowalski",
    "DateOfBirth": "1999-12-26T00:00:00",
    "JobTitle": "Administrator"
  },
  {
    "FirstName": "Anna",
    "LastName": "Kowalska",
    "DateOfBirth": "1998-11-24T00:00:00",
    "JobTitle": "Developer"
  }
 ]
}
```

### Search
Search (POST): `http://localhost:49277/company/search`

```
{
  "Keyword": "Kowalska",
  "EmployeeDateOfBirthFrom": "1999-11-22",
  "EmployeeDateOfBirthTo": "1999-11-28",
  "JobTitle": "Administrator"
}
```

### Delete
Delete (DELETE): `http://localhost:49277/company/delete/<company_id>`

