The following readme is a mess and work in progress!
There will be a proper readme, but as for new this is a file for thoughts!

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

TODO: Make api endpoint controller with CRUD


NOTE THAT: Lots of interfaces so the API is independent on the database type and placement!


test of the controller failed due to difference between versions.
To fix this the following was run in the test project NuGet console:
```
install-package Microsoft.AspNetCore.Mvc.Core
install-package Microsoft.AspNetCore.Mvc.Abstractions
install-package Microsoft.AspNetCore.Mvc.ViewFeatures
```

REMEMBER to add the interfaces as scoped to the startup file!


FakeItEasy for later use