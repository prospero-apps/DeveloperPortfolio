using DeveloperPortfolio.Models.Dtos;
using DeveloperPortfolio.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace DeveloperPortfolio.Web.Pages
{
    public class ProjectsByCategoryBase : ComponentBase
    {
        [Parameter]
        public int CategoryId { get; set; }

        [Inject]
        public IProjectService ProjectService { get; set; }

        [Inject]
        public ICategoryService CategoryService { get; set; }

        public IEnumerable<ProjectDto> Projects { get; set; }

        public string CategoryName { get; set; }
        public string ErrorMessage { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            try
            {
                Projects = await ProjectService.GetProjectsByCategory(CategoryId);

                var category = await CategoryService.GetCategory(CategoryId);

                if (category != null)
                {
                    CategoryName = category.Name;
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }
    }
}
