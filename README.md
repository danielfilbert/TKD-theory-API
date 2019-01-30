Followed the tutorial: https://docs.microsoft.com/en-us/ef/core/get-started/aspnetcore/existing-db

Install NuGet
Microsoft.EntityFrameworkCore

Reverse engineering the DB model
    
Scaffold-DbContext "Server=localhost\SQLEXPRESS;Database=Lokisaur-TKD-Theory-App;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Data

Swashbuck/Swagger via: https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-2.2&tabs=visual-studio

Install swagger via Swashbuckle NuGet package
Swashbuckle.AspNetCore

Make models and context

Make mapper and interface (test first though)