using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Traversal.Repository.Concretes
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<TraversalContext>
    {
        public TraversalContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<TraversalContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer(Configuration.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
