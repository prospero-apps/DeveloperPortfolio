using DeveloperPortfolio.Models.Dtos;
using DeveloperPortfolio.Web.Services;
using DeveloperPortfolio.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace DeveloperPortfolio.Web.Pages
{
    public class TechsBase : ComponentBase
    {
        [Inject]
        public ITechService TechService { get; set; }

        [Inject]
        public IProjectService ProjectService { get; set; }

        public IEnumerable<TechDto> Techs { get; set; }
        public IEnumerable<ProjectDto> Projects { get; set; }


        protected override async Task OnInitializedAsync()
        {
            Techs = await TechService.GetAllTechs();
            Projects = await ProjectService.GetAllProjects();
        }

        protected IEnumerable<ProjectDto> GetProjectsWithThisTech(int techId)
        {
            return Projects.Where(p => p.Techs.Any(t => t.Id == techId)); 
        }

        protected async Task DeleteTech_Click(int id)
        {
            var techDto = await TechService.DeleteTech(id);
            Techs = Techs.Where(t => t.Id != id);
        }
    }
}
