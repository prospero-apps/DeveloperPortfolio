using DeveloperPortfolio.Models.Dtos;
using DeveloperPortfolio.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace DeveloperPortfolio.Web.Pages
{
    public class ProjectsBase : ComponentBase
    {
        [Inject]
        public IProjectService ProjectService { get; set; }

        public IEnumerable<ProjectDto> Projects { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Projects = await ProjectService.GetAllProjects();
        }
    }
}
