using DeveloperPortfolio.Models.Dtos;

namespace DeveloperPortfolio.Web.Services.Contracts
{
    public interface ITechService
    {
        Task<IEnumerable<TechDto>> GetAllTechs();
        Task<TechDto> GetTech(int id);
        Task<TechDto> CreateTech(TechDto techDto);
    }
}
