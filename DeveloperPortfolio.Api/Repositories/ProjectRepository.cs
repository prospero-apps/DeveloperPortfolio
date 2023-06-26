using DeveloperPortfolio.Api.Data;
using DeveloperPortfolio.Api.Entities;
using DeveloperPortfolio.Api.Repositories.Contracts;
using DeveloperPortfolio.Models.Dtos;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

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

        public async Task<Project> CreateProject(ProjectDto projectDto)
        {
            var item = new Project
            {
                Name = projectDto.Name,
                Description = projectDto.Description,
                ImageUrl = projectDto.ImageUrl,
                CategoryId = projectDto.CategoryId
            };
                       
            if (item != null)
            {
                var result = await developerPortfolioDbContext.Projects.AddAsync(item);
                await developerPortfolioDbContext.SaveChangesAsync();

                // Handle techs
                if (projectDto.Techs != null)
                {
                    var relations = new List<ProjectTechRelation>();

                    foreach (var tech in projectDto.Techs)
                    {
                        relations.Add(new ProjectTechRelation
                        {
                            TechId = tech.Id,
                            ProjectId = item.Id
                        });
                    }

                    await developerPortfolioDbContext.AddRangeAsync(relations);
                }

                // Handle links
                if (projectDto.Links != null)
                {
                    var links = new List<Link>();

                    foreach (var link in projectDto.Links)
                    {
                        links.Add(new Link
                        {
                            Id = link.Id,
                            Destination = link.Destination,
                            DisplayText = link.DisplayText,
                            Icon = link.Icon,
                            ProjectId = item.Id
                        });
                    }

                    await developerPortfolioDbContext.AddRangeAsync(links);
                }

                await developerPortfolioDbContext.SaveChangesAsync();
                return result.Entity;
            }

            return null;
        }

        public Task<Project> UpdateProject(int id, ProjectDto projectDto)
        {
            throw new NotImplementedException();
        }

        public async Task<Project> DeleteProject(int id)
        {
            var item = await developerPortfolioDbContext.Projects.FindAsync(id);

            if (item != null)
            {
                // Handle techs
                var relations = await developerPortfolioDbContext.ProjectTechRelations
                    .Where(p => p.ProjectId == id).ToListAsync();

                developerPortfolioDbContext.RemoveRange(relations);

                // Handle links
                var links = await developerPortfolioDbContext.Links
                    .Where(l => l.ProjectId == id).ToListAsync();   

                developerPortfolioDbContext.RemoveRange(links);

                // Handle the project itself
                developerPortfolioDbContext.Projects.Remove(item);

                await developerPortfolioDbContext.SaveChangesAsync();
            }

            return item;
        }
    }
}
