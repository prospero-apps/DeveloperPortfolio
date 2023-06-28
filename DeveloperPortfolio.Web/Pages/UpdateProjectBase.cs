using DeveloperPortfolio.Models.Dtos;
using DeveloperPortfolio.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace DeveloperPortfolio.Web.Pages
{
    public class UpdateProjectBase : ComponentBase
    {
        [Parameter]
        public int Id { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        public IProjectService ProjectService { get; set; }
        public ProjectDto ProjectDto { get; set; }

        [Inject]
        public ICategoryService CategoryService { get; set; }
        public List<CategoryDto> Categories { get; set; }

        [Inject]
        public ITechService TechService { get; set; }
        public List<TechDto> Techs { get; set; }
        public int[] TechIds { get; set; }

        public List<TechDto> ProjectTechs { get; set; }
        public int[] ProjectTechIds { get; set; }
        public List<LinkDto> Links { get; set; } 
        public bool ReadyToAddLink { get; set; } = false;
        public string ErrorMessage { get; set; }
        public string ImageDataUri { get; set; }

        const long MAX_FILE_SIZE = 1024 * 1024 * 15;


        protected async override Task OnInitializedAsync()
        {
            try
            {
                ProjectDto = await ProjectService.GetProject(Id);

                Categories = (await CategoryService.GetAllCategories()).ToList();
                Techs = (await TechService.GetAllTechs()).ToList();

                TechIds = (from tech in Techs
                           select tech.Id).ToArray();

                ProjectTechs = ProjectDto.Techs;

                ProjectTechIds = (from tech in ProjectTechs
                                  select tech.Id).ToArray();

                ImageDataUri = ProjectDto.ImageUrl;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }

        protected async Task UpdateProject_Submit()
        {
            try
            {
                ProjectTechs = new List<TechDto>();

                foreach (var techId in ProjectTechIds)
                {
                    var tech = Techs.SingleOrDefault(t => t.Id == techId);

                    ProjectTechs.Add(tech);
                }

                ProjectDto.Techs = ProjectTechs;

                ProjectDto.ImageUrl = ImageDataUri;

                await ProjectService.UpdateProject(ProjectDto);

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

        public void RefreshState()
        {
            StateHasChanged();
        }
    }
}
