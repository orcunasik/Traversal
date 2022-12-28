using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
