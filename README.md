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

     ```bash
     CREATE DATABASE InsurancePolicyDb;
     ```

## Clone the Project
1. Clone the repository from GitHub or any source.
   ```bash
     git clone <backend-repo-url>
      cd <backend-repo-folder>
   ```
## Install Dependencies
1. Restore all dependencies:
   ```bash
   dotnet restore
   ```
### Configure the Database Connection
1. Open the `appsettings.json` file and update the connection string:

   ```bash
   {
       "ConnectionStrings": {
           "DefaultConnection": "Server=localhost;Database=InsurancePolicyDb;User=root;Password=yourpassword;"
       }
   }
   ```
### Run Migrations
1. Add initial migration:

   ```bash
   dotnet ef migrations add InitialCreate
   ```
2. Ensure dotnet-ef is installed. If not, install it globally:
   ```bash
   dotnet tool install --global dotnet-ef
   ```
### Run the Application
```bash
   dotnet run
```
The API will be accessible at http://localhost:5024.
