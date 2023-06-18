using DeveloperPortfolio.Models.Dtos;

namespace DeveloperPortfolio.Web.Services.Contracts
{
    public interface IProjectService
    {
        Task<IEnumerable<ProjectDto>> GetAllProjects();
    }
}
