using DeveloperPortfolio.Models.Dtos;

namespace DeveloperPortfolio.Web.Services.Contracts
{
    public interface IProjectService
    {
        Task<IEnumerable<ProjectDto>> GetAllProjects();        
        Task<IEnumerable<ProjectDto>> GetProjectsByCategory(int categoryId);
        Task<IEnumerable<ProjectDto>> GetProjectsByTech(int techId);
        Task<ProjectDto> GetProject(int id);
        Task<ProjectDto> CreateProject(ProjectDto projectDto);
        Task<ProjectDto> DeleteProject(int id);
    }
}
