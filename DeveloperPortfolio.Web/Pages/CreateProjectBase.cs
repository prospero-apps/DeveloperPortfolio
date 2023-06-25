using DeveloperPortfolio.Models.Dtos;
using DeveloperPortfolio.Web.Services;
using DeveloperPortfolio.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.IO;


namespace DeveloperPortfolio.Web.Pages
{
    public class CreateProjectBase : ComponentBase
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

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
        public string ErrorMessage { get; set; }        
        public string ImageDataUri { get; set; }

        const long MAX_FILE_SIZE = 1024 * 1024 * 15;


        protected async override Task OnInitializedAsync()
        {
            try
            {
                Categories = (await CategoryService.GetAllCategories()).ToList();
                Techs = (await TechService.GetAllTechs()).ToList();

                TechIds = (from tech in Techs
                           select tech.Id).ToArray();

                ProjectDto.Links = Links;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }            
        }

        protected async Task CreateProject_Submit()
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
                                
                ProjectDto.ImageUrl = ImageDataUri;

                await ProjectService.CreateProject(ProjectDto);

                NavigationManager.NavigateTo("/");                
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

        protected async Task HandleImageUpload(InputFileChangeEventArgs e)
        {
            var imageFile = await e.File.RequestImageFileAsync("image/jpeg", maxWidth: 640, maxHeight: 480);
            using Stream fileStream = imageFile.OpenReadStream(MAX_FILE_SIZE);
            using MemoryStream ms = new();

            await fileStream.CopyToAsync(ms);

            ImageDataUri = $"data:image/jpeg;base64,{Convert.ToBase64String(ms.ToArray())}";
        }
    }
}
