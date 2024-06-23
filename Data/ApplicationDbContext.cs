using crud_interface.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace crud_interface.Data;

public class ApplicationDbContext : DbContext
{


    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    { } 
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=163.123.183.80,18501;Database=CSHARP_DB;
                User ID=eliseu441;Password=Trembolona550;Integrated Security=False;Trusted_Connection=False;TrustServerCertificate=True;");
    }

    public DbSet<Student> Students { get; set; } = default!;
    public DbSet<Premium> Premium { get; set; } = default!;

}
