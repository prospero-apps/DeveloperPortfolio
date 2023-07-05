using DeveloperPortfolio.Models.Dtos;
using DeveloperPortfolio.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace DeveloperPortfolio.Web.Pages
{
    public class EditProjectsBase : ComponentBase
    {
        [Inject]
        public IProjectService ProjectService { get; set; }

        public IEnumerable<ProjectDto> Projects { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Projects = await ProjectService.GetAllProjects();
        }

        protected IOrderedEnumerable<IGrouping<int, ProjectDto>> GetGroupedProjects()
        {
            return from project in Projects
                   group project by project.CategoryId into projectGroup
                   orderby projectGroup.Key
                   select projectGroup;
        }

        protected string GetCategoryName(IGrouping<int, ProjectDto> groupedProjectDtos)
        {
            return groupedProjectDtos.FirstOrDefault(p => p.CategoryId == groupedProjectDtos.Key).CategoryName;
        }

        public void RefreshState(IEnumerable<ProjectDto> projects)
        {
            Projects = projects;
            StateHasChanged();
        }
    }
}
