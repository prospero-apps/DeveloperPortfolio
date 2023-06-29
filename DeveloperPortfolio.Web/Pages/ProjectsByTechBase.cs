using DeveloperPortfolio.Models.Dtos;
using DeveloperPortfolio.Web.Services;
using DeveloperPortfolio.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace DeveloperPortfolio.Web.Pages
{
    public class ProjectsByTechBase : ComponentBase
    {
        [Parameter]
        public int TechId { get; set; }

        [Inject]
        public IProjectService ProjectService { get; set; }

        [Inject]
        public ITechService TechService { get; set; }

        public IEnumerable<ProjectDto> Projects { get; set; }
        public string TechName { get; set; }
        public string ErrorMessage { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            try
            {
                Projects = await ProjectService.GetProjectsByTech(TechId);

                var tech = await TechService.GetTech(TechId);

                if (tech != null)
                {
                    TechName = tech.Name;
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }
    }
}
