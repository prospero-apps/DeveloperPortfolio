using DeveloperPortfolio.Models.Dtos;
using DeveloperPortfolio.Web.Services;
using DeveloperPortfolio.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace DeveloperPortfolio.Web.Pages
{
    public class CreateProjectBase : ComponentBase
    {      
        [Inject]
        public IProjectService ProjectService { get; set; }
        public ProjectDto ProjectDto = new ProjectDto();

        [Inject]
        public ICategoryService CategoryService { get; set; }
        public List<CategoryDto> Categories { get; set; }

        [Inject]
        public ITechService TechService { get; set; }
        public List<TechDto> Techs { get; set; }

        public int[] TechIds { get; set; }

        public List<LinkDto> Links { get; set; } = new List<LinkDto>();

        public bool ReadyToAddLink { get; set; } = false;

        protected async override Task OnInitializedAsync()
        {
            Categories = (await CategoryService.GetAllCategories()).ToList();
            Techs = (await TechService.GetAllTechs()).ToList();

            TechIds = (from tech in Techs
                      select tech.Id).ToArray();

            ProjectDto.Links = Links;
        }

        protected async void CreateProject_Submit()
        {
            try
            {
                var category = await CategoryService.GetCategory(ProjectDto.CategoryId);
                ProjectDto.CategoryName = category.Name;

                var ProjectTechs = new List<TechDto>();

                foreach (var techId in TechIds) 
                {
                    var tech = Techs.SingleOrDefault(t => t.Id == techId);

                    ProjectTechs.Add(tech);
                }

                ProjectDto.Techs = ProjectTechs;


                await ProjectService.CreateProject(ProjectDto);
            }
            catch (Exception)
            {
                throw;
            }
        }        

        protected void AddLink_Click()
        {
            ReadyToAddLink = true;
        }

        public void RemoveAddLink()
        {
            ReadyToAddLink = false;
        }
    }
}
