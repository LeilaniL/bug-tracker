# Bug Tracker

##### A journal for bugs and errors

## Description

This is a web app to let users quickly record bugs, so they have a searchable database of errors and solutions. Built with C# and ASP.NET plus React. Currently a work-in-progress. 🔨

## Setup Instructions
**Required: <a href="https://dev.mysql.com/doc/" target="_blank">MySQL Server</a>, <a href="https://dotnet.microsoft.com/download/dotnet-core/2.2" target="_blank">.NET Core 2.2</a>**
1) Clone or download this project
2) Update `appsettings.json` with your MySQL password
3) In the terminal, navigate to the project folder ("BugTrackerReact")
4) Enter the command: `dotnet ef database update` to run a database migration
5) Enter the command: `dotnet run` to restore, build, and run the server
6) Visit localhost:5001 in the browser

## Roadmap

| to do                              | doing                                                | done            |   |   |
|------------------------------------|------------------------------------------------------|-----------------|---|---|
|                                    |                                                      | GET/POST issues |   |   |
|                                    | save issue summary, steps, and solution              |                 |   |   |
|                                    | return a list of all issues after creating a new one |                 |   |   |
| search issues by name, description |                                                      |                 |   |   |
| add tags to issues                 |                                                      |                 |   |   |
| return issues by tag               |                                                      |                 |   |   |
| register/login a user              |                                                      |                 |   |   |
| edit an issue                      |                                                      |                 |   |   |
| delete an issue                    |                                                      |                 |   |   |
| share issue on social media?       |                                                      |                 |   |   |
|                                    |                                                      |                 |   |   |

-----

## Technologies Used

* React
* ASP.NET 
* MySql
* Entity Framework Core

## License

MIT License

Copyright (c) 2020 Leilani Leach

