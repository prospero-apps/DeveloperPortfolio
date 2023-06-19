using DeveloperPortfolio.Api.Entities;
using DeveloperPortfolio.Models.Dtos;

namespace DeveloperPortfolio.Api.Extensions
{
    public static class DtoConversions
    {
        // Projects
        public static IEnumerable<ProjectDto> ConvertToDto(this IEnumerable<Project> projects,
            IEnumerable<Category> categories, IEnumerable<Tech> techs, IEnumerable<Link> links,
            IEnumerable<ProjectTechRelation> relations)
        {
            return (from project in projects
                    join category in categories
                    on project.CategoryId equals category.Id
                    select new ProjectDto
                    {
                        Id = project.Id,
                        Name = project.Name,
                        Description = project.Description,
                        ImageUrl = project.ImageUrl,
                        CategoryId = project.CategoryId,
                        CategoryName = category.Name,
                        Techs = (from relation in relations
                                 where relation.ProjectId == project.Id
                                 join tech in techs
                                 on relation.TechId equals tech.Id
                                 select new TechDto
                                 {
                                     Id = tech.Id,
                                     Name = tech.Name,
                                     Icon = tech.Icon
                                 }).ToList(),
                        Links = (from link in links
                                 where link.ProjectId == project.Id
                                 select new LinkDto
                                 {
                                     Id = link.Id,
                                     Destination = link.Destination,
                                     DisplayText = link.DisplayText,
                                     Icon = link.Icon,
                                     ProjectId = project.Id
                                 }).ToList()
                    }).ToList();            
        }

        public static ProjectDto ConvertToDto(this Project project,
            Category category, IEnumerable<Tech> techs, IEnumerable<Link> links,
            IEnumerable<ProjectTechRelation> relations)
        {
            return new ProjectDto
            {
                Id = project.Id,
                Name = project.Name,
                Description = project.Description,
                ImageUrl = project.ImageUrl,
                CategoryId = project.CategoryId,
                CategoryName = category.Name,
                Techs = (from relation in relations
                         where relation.ProjectId == project.Id
                         join tech in techs
                         on relation.TechId equals tech.Id
                         select new TechDto
                         {
                             Id = tech.Id,
                             Name = tech.Name,
                             Icon = tech.Icon
                         }).ToList(),
                Links = (from link in links
                         where link.ProjectId == project.Id
                         select new LinkDto
                         {
                             Id = link.Id,
                             Destination = link.Destination,
                             DisplayText = link.DisplayText,
                             Icon = link.Icon,
                             ProjectId = project.Id
                         }).ToList()
            };
        }

        // Categories
        public static IEnumerable<CategoryDto> ConvertToDto(this IEnumerable<Category> categories)
        {
            return (from category in categories
                    select new CategoryDto
                    {
                        Id = category.Id,
                        Name = category.Name,
                        Icon = category.Icon
                    }).ToList();
        }

        public static CategoryDto ConvertToDto(this Category category)
        {
            return new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                Icon = category.Icon
            };
        }

        // Techs
        public static IEnumerable<TechDto> ConvertToDto(this IEnumerable<Tech> techs)
        {
            return (from tech in techs
                    select new TechDto
                    {
                        Id = tech.Id,
                        Name = tech.Name,
                        Icon = tech.Icon
                    }).ToList();
        }

        public static TechDto ConvertToDto(this Tech tech)
        {
            return new TechDto
            {
                Id = tech.Id,
                Name = tech.Name,
                Icon = tech.Icon
            };
        }
    }
}
