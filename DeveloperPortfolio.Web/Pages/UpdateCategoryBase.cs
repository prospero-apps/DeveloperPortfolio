using DeveloperPortfolio.Models.Dtos;
using DeveloperPortfolio.Web.Services;
using DeveloperPortfolio.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace DeveloperPortfolio.Web.Pages
{
    public class UpdateCategoryBase : ComponentBase
    {
        [Parameter]
        public int Id { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public CategoryDto CategoryDto { get; set; }
        public string ErrorMessage { get; set; }

        [Inject]
        public ICategoryService CategoryService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                CategoryDto = await CategoryService.GetCategory(Id);
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }

        protected async Task UpdateCategory_Submit()
        {
            try
            {               
                await CategoryService.UpdateCategory(CategoryDto);
                NavigationManager.NavigateTo("/");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
