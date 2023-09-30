using GraphQlProject.Model;
using Microsoft.EntityFrameworkCore;

namespace GraphQlProject.Infrastructure.DbContexts
{
    public class GraphQlDbContext: DbContext
    {
        public GraphQlDbContext(DbContextOptions<GraphQlDbContext> options ): base(options)
        {
            
        }

        public DbSet<Menu> Menus { get; set; }
    }
}
