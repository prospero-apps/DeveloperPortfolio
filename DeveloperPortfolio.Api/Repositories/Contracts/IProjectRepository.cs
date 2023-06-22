using DeveloperPortfolio.Api.Entities;
using DeveloperPortfolio.Models.Dtos;

namespace DeveloperPortfolio.Api.Repositories.Contracts
{
    public interface IProjectRepository
    {        
        Task<IEnumerable<Project>> GetAllProjects();
        Task<IEnumerable<Project>> GetProjectsByCategory(int id);
        Task<IEnumerable<Project>> GetProjectsByTech(int id);
        Task<IEnumerable<Tech>> GetProjectTechs(int projectId);
        Task<IEnumerable<Link>> GetAllLinks();
        Task<IEnumerable<Link>> GetProjectLinks(int projectId);
        Task<Project> GetProject(int id);
        Task<IEnumerable<ProjectTechRelation>> GetAllProjectTechRelations();
        Task<Project> CreateProject(ProjectDto projectDto);
        Task<Project> UpdateProject(int id, ProjectDto projectDto);
        Task<Project> DeleteProject(int id);
    }
}
