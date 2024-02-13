# Eau Claire's Salon

## Table of Contents
- [About](#about)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Installation](#installation)
- [Setting Up SQL](#setting-up-sql)
- [Known Bugs](#known-bugs)
- [License](#license)
- [Contact](#contact)

## About
This MVC web application manages a hair salon's stylists and their clients, allowing the salon owner to add stylists, view stylist details, and manage clients associated with each stylist.

## Features
Create stylists and clients. Each stylist can have multiple clients, but each client may only have one stylist.

## Technologies Used
- **Language**: C#
- **Framework**: .NET 5.0 or .NET 6.0
- **IDE**: Visual Studio 2019 or 2022
- **Database Management**: Entity Framework Core, Pomelo.EntityFrameworkCore.MySql
- **Version Control**: Git

## Installation
To set up this project locally, follow these steps:

1. **Clone the Repository**
git clone https://github.com/Christopher-Quattrocchi/HairSalon-fridayproject.git

2. **Navigate to the Project Directory**
cd HairSalon

3. **Restore Dependencies**
dotnet restore

4. **Build the Project**
dotnet build

5. **Run the Project**
dotnet run

Access the application through a web browser at the indicated URL, typically `http://localhost:5000`.

## Setting up the SQL Database

This project uses a SQL database to store and manage data. Follow the instructions below to set up the database environment:

### Prerequisites

- If needed, install SQL Workbench: [official website](https://www.mysql.com/products/workbench/).

1. **Open SQL Workbench** and connect to your MySQL server.

2. **Import the Database Schema**:
   - In the top menu, navigate to `Server` > `Data Import`.
   - Choose "Import from Self-Contained File" and select the `chris_quattrocchi.sql` file located in your project directory.
   - Under "Default Target Schema", either select an existing schema or create a new one to import the tables into.
   - Click `Start Import` at the bottom right to execute the script and create the tables in your database.

3. **Configure Connection String**:
   - In your application's `appsettings.json` file, update the connection string to match your database name and credentials:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=localhost;Database=yourDatabaseName;Uid=yourUsername;Pwd=yourPassword;"
     }
   }

## Apply Migrations:
dotnet ef database update

## Known Bugs
Unknown

## License
This project is licensed under the MIT License.

## Contact
chrisquattrocchi@gmail.com





