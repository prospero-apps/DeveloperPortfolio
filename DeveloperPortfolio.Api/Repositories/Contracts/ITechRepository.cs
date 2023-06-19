using DeveloperPortfolio.Api.Entities;
using DeveloperPortfolio.Models.Dtos;

namespace DeveloperPortfolio.Api.Repositories.Contracts
{
    public interface ITechRepository
    {        
        Task<IEnumerable<Tech>> GetAllTechs();

        Task<Tech> GetTech(int id);

        Task<Tech> CreateTech(TechDto techDto);

        Task<Tech> UpdateTech(int id, TechDto techDto);
        
        Task<Tech> DeleteTech(int id);
    }
}
