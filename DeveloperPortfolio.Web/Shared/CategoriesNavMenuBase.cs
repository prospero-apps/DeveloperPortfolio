using DeveloperPortfolio.Models.Dtos;
using DeveloperPortfolio.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace DeveloperPortfolio.Web.Shared
{
    public class CategoriesNavMenuBase : ComponentBase
    {
        [Inject]
        public ICategoryService CategoryService { get; set; }

        public IEnumerable<CategoryDto> CategoryDtos { get; set; }

        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                CategoryDtos = await CategoryService.GetAllCategories();
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }
    }
}
