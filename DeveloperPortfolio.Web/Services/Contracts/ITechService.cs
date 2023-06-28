using DeveloperPortfolio.Models.Dtos;

namespace DeveloperPortfolio.Web.Services.Contracts
{
    public interface ITechService
    {
        Task<IEnumerable<TechDto>> GetAllTechs();
        Task<TechDto> GetTech(int id);
        Task<TechDto> CreateTech(TechDto techDto);
        Task<TechDto> UpdateTech(TechDto techDto);
        Task<TechDto> DeleteTech(int id);
    }
}
