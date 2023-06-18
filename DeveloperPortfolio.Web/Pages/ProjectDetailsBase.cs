using DeveloperPortfolio.Models.Dtos;
using DeveloperPortfolio.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace DeveloperPortfolio.Web.Pages
{
    public class ProjectDetailsBase : ComponentBase
    {
        [Parameter]
        public int Id { get; set; }

        [Inject]
        public IProjectService ProjectService { get; set; }

        public ProjectDto Project { get; set; }
        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                Project = await ProjectService.GetProject(Id);
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }
    }
}
