# ODataService-Example
Steps

1. Create the Database and run database scripts on database.
2. Create .Net Core Web Api in Visual Studio
3. Install EntityFrameworkCore
https://docs.microsoft.com/en-us/ef/core/get-started/install/
Open Nuget Package Manger console and run: Install-Package Microsoft.EntityFrameworkCore.SqlServer
4. Scaffold Model with EntityFrameworkCore 	https://docs.microsoft.com/en-us/ef/core/get-started/aspnetcore/existing-db
  In the package manager console run:
    Scaffold-DbContext "Server=tcp:YOURDATABASE.database.windows.net,1433;Initial Catalog=CESDevDB;Persist Security Info=False;User ID=USERNAMEHERE;Password=PASSWORDHERE;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;" Microsoft.EntityFrameworkCore.SqlServer -d -o Models
    
    (Change it to your connection string)
5. Import namespace by adding using Microsoft.EntityFrameworkCore; and using CoordinatedEntryAPI.Models; to the tartup.cs file.
6. Add the following to the bottom of the configureservices of startup.cs:

var connection = @"Server=tcp:YOURDATABASE.database.windows.net,1433;Initial Catalog=CESDevDB;Persist Security Info=False;User ID=USERNAMEHERE;Password=PASSWORDHERE!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
services.AddDbContext<CESDBContext>(options => options.UseSqlServer(connection));

 
7. Install OData. In the package manager console run:

Run Install-Package Microsoft.AspNetCore.OData

8. Add OData to your startup.cs file and add ability to do dependency injection to your route
  
  services.AddOData();
  
  app.UseMvc(routeBuilder =>
  {
      //user current routing scheme
      routeBuilder.EnableDependencyInjection();
      //enables odata functions
      routeBuilder.Select().Filter().Expand().OrderBy().Count().MaxTop(null);
  });

  
9. Add [EnableQuery] decorators to your controller.
