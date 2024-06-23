comandos utilizados pra automatizar a criação da interface:


dotnet new razor -o crud-interface --auth Individual
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet tool install --global dotnet-ef
dotnet ef migrations add v1
dotnet ef database update
dotnet tool install -g dotnet-aspnet-codegenerator
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet aspnet-codegenerator razorpage Create Create -m Student -dc ApplicationDbContext -udl -outDir Pages/Students
dotnet aspnet-codegenerator razorpage Edit Edit -m Student -dc ApplicationDbContext -udl -outDir Pages/Students
dotnet aspnet-codegenerator razorpage Delete Delete -m Student -dc ApplicationDbContext -udl -outDir Pages/Students
dotnet aspnet-codegenerator razorpage Details Details -m Student -dc ApplicationDbContext -udl -outDir Pages/Students
dotnet aspnet-codegenerator razorpage Index List -m Student -dc ApplicationDbContext -udl -outDir Pages/Students

dotnet aspnet-codegenerator razorpage Create Create -m Premium -dc ApplicationDbContext -udl -outDir Pages/Premiums
dotnet aspnet-codegenerator razorpage Edit Edit -m Premium -dc ApplicationDbContext -udl -outDir Pages/Premiums
dotnet aspnet-codegenerator razorpage Delete Delete -m Premium -dc ApplicationDbContext -udl -outDir Pages/Premiums
dotnet aspnet-codegenerator razorpage Details Details -m Premium -dc ApplicationDbContext -udl -outDir Pages/Premiums
dotnet aspnet-codegenerator razorpage Index List -m Premium -dc ApplicationDbContext -udl -outDir Pages/Premiums
