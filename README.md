InsurancePolicyAPI Setup Instructions

Prerequisites
Install .NET SDK

Download and install the latest .NET SDK from Microsoft .NET.
Confirm installation:

dotnet --version
Install MySQL

Install MySQL Server and MySQL Workbench from MySQL Downloads.
Ensure the MySQL service is running.
Set up a MySQL Database

Log in to MySQL:
mysql -u root -p
Create a database:
CREATE DATABASE InsurancePolicyDb;
Install a Code Editor

Use an editor like Visual Studio Code or Rider.
Clone the Project

Install Dependencies
Restore all dependencies:

dotnet restore

Configure the Database Connection
Open the appsettings.json file and update the connection string:
json
Copy code
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Database=InsurancePolicyDb;User=root;Password=yourpassword;"
    }
}

Use environment variables for sensitive data:
Add the connection string to your environment variables.
Run Migrations

Add initial migration:
dotnet ef migrations add InitialCreate

Apply migrations to the database:
dotnet ef database update

Run the Application
Start the application:

dotnet run
The API will be accessible at https://localhost:5001 or http://localhost:5000.
Scaffold Controllers

dotnet aspnet-codegenerator controller -name InsurancePolicyController -async -api -m InsurancePolicy -dc PolicyDbContext -outDir Controllers

Test the API
Open your browser or use an API client like Postman to test endpoints.
Example endpoints:
GET /api/InsurancePolicies – Retrieve all policies.
POST /api/InsurancePolicies – Create a new policy.
PUT /api/InsurancePolicies/{id} – Update an existing policy.
DELETE /api/InsurancePolicies/{id} – Delete a policy.



Common Issues and Troubleshooting
Database Connection Issues
Ensure MySQL is running and the connection string is correct.
Migration Issues
Port Conflicts
Change the port number in launchSettings.json.


# InsurancePolicyAPI Setup Instructions

## Prerequisites
1. **Install .NET SDK**
   - Download and install the latest .NET SDK from [Microsoft .NET](https://dotnet.microsoft.com/download).
   - Confirm installation:

     ```bash
     dotnet --version
     ```

2. **Install MySQL**
   - Install MySQL Server and MySQL Workbench from [MySQL Downloads](https://dev.mysql.com/downloads/).
   - Ensure the MySQL service is running.

3. **Set up a MySQL Database**
   - Log in to MySQL:

     ```bash
     mysql -u root -p
     ```

   - Create a database:

     ```sql
     CREATE DATABASE InsurancePolicyDb;
     ```

4. **Install a Code Editor**
   - Use an editor like Visual Studio Code or Rider.

## Clone the Project
1. Clone the repository from GitHub or any source.

## Install Dependencies
1. Restore all dependencies:

   ```bash
   dotnet restore

---

### Configure the Database Connection

```markdown
## Configure the Database Connection
1. Open the `appsettings.json` file and update the connection string:

   ```json
   {
       "ConnectionStrings": {
           "DefaultConnection": "Server=localhost;Database=InsurancePolicyDb;User=root;Password=yourpassword;"
       }
   }


---

### Run Migrations

```markdown
## Run Migrations
1. Add initial migration:

   ```bash
   dotnet ef migrations add InitialCreate



---

### Run the Application

```markdown
## Run the Application
1. Start the application:

   ```bash
   dotnet run


---

### Test the API

```markdown
## Test the API
1. Open your browser or use an API client like Postman to test endpoints.
   - Example endpoints:
     - `GET /api/InsurancePolicies` – Retrieve all policies.
     - `POST /api/InsurancePolicies` – Create a new policy.
     - `PUT /api/InsurancePolicies/{id}` – Update an existing policy.
     - `DELETE /api/InsurancePolicies/{id}` – Delete a policy.

## Common Issues and Troubleshooting
### Database Connection Issues
- Ensure MySQL is running and the connection string is correct.

### Migration Issues
- Ensure MySQL service is running.
- Verify connection string.

### Port Conflicts
- Change the port number in `launchSettings.json`.


