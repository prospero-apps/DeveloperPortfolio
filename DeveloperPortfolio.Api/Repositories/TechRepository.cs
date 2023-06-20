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

        public async Task<Tech> CreateTech(TechDto techDto)
        {
            if (await TechWithThisNameExists(techDto.Name) == false)
            {
                var item = new Tech
                {
                    Id = techDto.Id,
                    Name = techDto.Name,
                    Icon = techDto.Icon
                };

                if (item != null)
                {
                    var result = await developerPortfolioDbContext.Techs.AddAsync(item);
                    await developerPortfolioDbContext.SaveChangesAsync();
                    return result.Entity;
                }
            }

            return null;
        }

        public Task<Tech> DeleteTech(int id)
        {
            throw new NotImplementedException();
        }
               
        public Task<Tech> UpdateTech(int id, TechDto techDto)
        {
            throw new NotImplementedException();
        }

        private async Task<bool> TechWithThisNameExists(string name)
        {
            return await developerPortfolioDbContext.Techs.AnyAsync(c => c.Name == name);
        }
    }
}
