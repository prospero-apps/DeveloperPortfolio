using DeveloperPortfolio.Api.Data;
using DeveloperPortfolio.Api.Entities;
using DeveloperPortfolio.Api.Repositories.Contracts;
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

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            var categories = await this.developerPortfolioDbContext.Categories.ToListAsync();
            return categories;
        }

        public async Task<IEnumerable<Project>> GetAllProjects()
        {
            var projects = await this.developerPortfolioDbContext.Projects.ToListAsync();
            return projects;
        }

        public async Task<IEnumerable<Tech>> GetAllTechs()
        {
            var techs = await this.developerPortfolioDbContext.Techs.ToListAsync();
            return techs;
        }

        public async Task<Category> GetCategory(int id)
        {
            var category = await developerPortfolioDbContext.Categories.SingleOrDefaultAsync(c =>  c.Id == id);
            return category;
        }

        public async Task<Project> GetProject(int id)
        {
            var project = await this.developerPortfolioDbContext.Projects.SingleOrDefaultAsync(p => p.Id == id);
            return project;
        }

        public async Task<IEnumerable<Link>> GetAllLinks()
        {
            var links = await this.developerPortfolioDbContext.Links.ToListAsync();
            return links;
        }

        public async Task<IEnumerable<Link>> GetProjectLinks(int projectId)
        {
            var links = await this.developerPortfolioDbContext.Links
                                  .Where(l => l.ProjectId == projectId).ToListAsync();
            
            return links;
        }

        public async Task<IEnumerable<Project>> GetProjectsByCategory(int id)
        {
            var projects = await this.developerPortfolioDbContext.Projects
                                     .Where(p => p.CategoryId == id).ToListAsync();

            return projects;
        }

        public async Task<IEnumerable<Project>> GetProjectsByTech(int id)
        {
            var relations = await this.developerPortfolioDbContext.ProjectTechRelations
                                      .Where(r => r.TechId == id).ToListAsync();

            var projectIds = relations.Select(r => r.ProjectId).ToList();

            var projects = await this.developerPortfolioDbContext.Projects
                                     .Where(p => projectIds.Contains(p.Id)).ToListAsync();

            return projects;
        }

        public async Task<IEnumerable<Tech>> GetProjectTechs(int projectId)
        {
            var relations = await this.developerPortfolioDbContext.ProjectTechRelations
                                      .Where(r => r.ProjectId == projectId).ToListAsync();

            var techIds = relations.Select(r => r.TechId).ToList();

            var techs = await this.developerPortfolioDbContext.Techs
                                  .Where(t => techIds.Contains(t.Id)).ToListAsync();

            return techs;
        }

        public async Task<IEnumerable<ProjectTechRelation>> GetAllProjectTechRelations()
        {
            var relations = await this.developerPortfolioDbContext.ProjectTechRelations.ToListAsync();
            return relations;
        }
    }
}
