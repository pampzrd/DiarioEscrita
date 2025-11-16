using Microsoft.EntityFrameworkCore;

namespace DiarioEscrita.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
    {
        
    }
}