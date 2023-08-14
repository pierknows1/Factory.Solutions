Factory

by Pier Rodriguez

A C# web application using Entity Framework Core to establish a relationship between machine and engineer at a factory.

Technologies Used

C#
.NET
Entity Framework Core
MySql

Description

Description
This is site built for the user to manage their machines and employees who are able to maintain those machines while storing all information from the user in a database.

Setup/Installation Requirements
Clone this repo.
Open the terminal and navigate to this project's production directory called "Factory.Solution".
Within the production directory "Factory", create a new file called appsettings.json.
Within appsettings.json, put in the following code.
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DATABASE-NAME];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}

Within the production directory "Factory", run dotnet watch run in the command line to start the project in development mode with a watcher.

Open the browser to https://localhost:5001.

Known Bugs
N/A

Copyright (c) 2023 authored by: Pier Rodriguez