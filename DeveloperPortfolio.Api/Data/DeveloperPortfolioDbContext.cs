using Microsoft.EntityFrameworkCore;

namespace DeveloperPortfolio.Api.Data
{
    public class DeveloperPortfolioDbContext : DbContext
    {
        public DeveloperPortfolioDbContext(DbContextOptions<DeveloperPortfolioDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
