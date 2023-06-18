using DeveloperPortfolio.Api.Entities;

namespace DeveloperPortfolio.Api.Repositories.Contracts
{
    public interface IProjectRepository
    {
        Task<IEnumerable<Project>> GetAllProjects();
        Task<IEnumerable<Project>> GetProjectsByCategory(int id);
        Task<IEnumerable<Project>> GetProjectsByTech(int id);
        Task<IEnumerable<Category>> GetAllCategories();
        Task<IEnumerable<Tech>> GetAllTechs();
        Task<IEnumerable<Tech>> GetProjectTechs(int projectId);
        Task<IEnumerable<Link>> GetAllLinks();
        Task<IEnumerable<Link>> GetProjectLinks(int projectId);
        Task<Project> GetProject(int id);
        Task<Category> GetCategory(int id);
        Task<IEnumerable<ProjectTechRelation>> GetAllProjectTechRelations();
    }
}
