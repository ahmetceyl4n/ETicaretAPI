using ETicaretAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ETicaretAPI.Persistence;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ETicaretAPIDbContext>
{
    public ETicaretAPIDbContext CreateDbContext(string[] args)
    {
        

        var builder = new DbContextOptionsBuilder<ETicaretAPIDbContext>();
        builder.UseNpgsql(Configuration.ConnectionString);

        return new ETicaretAPIDbContext(builder.Options);
    }
}
