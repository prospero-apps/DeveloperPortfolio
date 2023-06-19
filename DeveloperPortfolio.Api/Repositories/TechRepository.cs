using DeveloperPortfolio.Api.Data;
using DeveloperPortfolio.Api.Entities;
using DeveloperPortfolio.Api.Repositories.Contracts;
using DeveloperPortfolio.Models.Dtos;
using Microsoft.EntityFrameworkCore;

namespace DeveloperPortfolio.Api.Repositories
{
    public class TechRepository : ITechRepository
    {
        private readonly DeveloperPortfolioDbContext developerPortfolioDbContext;

        public TechRepository(DeveloperPortfolioDbContext developerPortfolioDbContext)
        {
            this.developerPortfolioDbContext = developerPortfolioDbContext;
        }

        public async Task<IEnumerable<Tech>> GetAllTechs()
        {
            var techs = await developerPortfolioDbContext.Techs.ToListAsync();
            return techs;
        }

        public async Task<Tech> GetTech(int id)
        {
            var tech = await developerPortfolioDbContext.Techs.SingleOrDefaultAsync(t => t.Id == id);
            return tech;
        }

        public Task<Tech> CreateTech(TechDto techDto)
        {
            throw new NotImplementedException();
        }

        public Task<Tech> DeleteTech(int id)
        {
            throw new NotImplementedException();
        }
               
        public Task<Tech> UpdateTech(int id, TechDto techDto)
        {
            throw new NotImplementedException();
        }        
    }
}
