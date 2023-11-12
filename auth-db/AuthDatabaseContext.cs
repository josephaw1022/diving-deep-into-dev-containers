using Microsoft.EntityFrameworkCore;
namespace auth_db;

public class AuthDatabaseContext : DbContext
{
    public AuthDatabaseContext(DbContextOptions<AuthDatabaseContext> options) : base(options) { }

    //* Tables 
    public DbSet<AuthUser> AuthUsers { get; set; } = null!;
    public DbSet<Session> Sessions { get; set; } = null!;
}