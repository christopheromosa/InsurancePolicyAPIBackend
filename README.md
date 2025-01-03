Create a new web API project and open it in Visual Studio Code.
Add a NuGet package that is needed for the next section.
Open the InsurancePolicyApiBackend folder in the current instance of Visual Studio Code.

dotnet new webapi --use-controllers -o InsurancePolicyApiBackend
cd InsurancePolicyApiBackend
dotnet add package Pomelo.EntityFrameworkCore.MySql
dotnet add package Microsoft.EntityFrameworkCore.Design --version 8.0.2
code -r ../InsurancePolicyApiBackend
