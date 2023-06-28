using DeveloperPortfolio.Models.Dtos;
using DeveloperPortfolio.Web.Services;
using DeveloperPortfolio.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace DeveloperPortfolio.Web.Pages
{
    public class UpdateTechBase : ComponentBase
    {
        [Parameter]
        public int Id { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public TechDto TechDto { get; set; }
        public string ErrorMessage { get; set; }

        [Inject]
        public ITechService TechService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                TechDto = await TechService.GetTech(Id);
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }

        protected async Task UpdateTech_Submit()
        {
            try
            {              
                await TechService.UpdateTech(TechDto);
                NavigationManager.NavigateTo("/");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
