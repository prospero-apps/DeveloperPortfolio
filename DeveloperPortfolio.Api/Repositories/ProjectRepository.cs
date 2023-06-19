using DeveloperPortfolio.Api.Data;
using DeveloperPortfolio.Api.Entities;
using DeveloperPortfolio.Api.Repositories.Contracts;
using DeveloperPortfolio.Models.Dtos;
using Microsoft.EntityFrameworkCore;

namespace DeveloperPortfolio.Api.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly DeveloperPortfolioDbContext developerPortfolioDbContext;

        public ProjectRepository(DeveloperPortfolioDbContext developerPortfolioDbContext)
        {
            this.developerPortfolioDbContext = developerPortfolioDbContext;
        }
         
        public async Task<IEnumerable<Project>> GetAllProjects()
        {
            var projects = await developerPortfolioDbContext.Projects.ToListAsync();
            return projects;
        }
                
        public async Task<Project> GetProject(int id)
        {
            var project = await developerPortfolioDbContext.Projects.SingleOrDefaultAsync(p => p.Id == id);
            return project;
        }

        public async Task<IEnumerable<Link>> GetAllLinks()
        {
            var links = await developerPortfolioDbContext.Links.ToListAsync();
            return links;
        }

        public async Task<IEnumerable<Link>> GetProjectLinks(int projectId)
        {
            var links = await developerPortfolioDbContext.Links
                                  .Where(l => l.ProjectId == projectId).ToListAsync();
            
            return links;
        }

        public async Task<IEnumerable<Project>> GetProjectsByCategory(int id)
        {
            var projects = await developerPortfolioDbContext.Projects
                                     .Where(p => p.CategoryId == id).ToListAsync();

            return projects;
        }

        public async Task<IEnumerable<Project>> GetProjectsByTech(int id)
        {
            var relations = await developerPortfolioDbContext.ProjectTechRelations
                                      .Where(r => r.TechId == id).ToListAsync();

            var projectIds = relations.Select(r => r.ProjectId).ToList();

            var projects = await developerPortfolioDbContext.Projects
                                     .Where(p => projectIds.Contains(p.Id)).ToListAsync();

            return projects;
        }

        public async Task<IEnumerable<Tech>> GetProjectTechs(int projectId)
        {
            var relations = await developerPortfolioDbContext.ProjectTechRelations
                                      .Where(r => r.ProjectId == projectId).ToListAsync();

            var techIds = relations.Select(r => r.TechId).ToList();

            var techs = await developerPortfolioDbContext.Techs
                                  .Where(t => techIds.Contains(t.Id)).ToListAsync();

            return techs;
        }

        public async Task<IEnumerable<ProjectTechRelation>> GetAllProjectTechRelations()
        {
            var relations = await developerPortfolioDbContext.ProjectTechRelations.ToListAsync();
            return relations;
        }        
    }
}
