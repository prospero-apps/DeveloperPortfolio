using DeveloperPortfolio.Models.Dtos;
using DeveloperPortfolio.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace DeveloperPortfolio.Web.Pages
{
    public class CreateTechBase : ComponentBase
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public TechDto TechDto = new TechDto();

        [Inject]
        public ITechService TechService { get; set; }

        protected async Task CreateTech_Submit()
        {
            try
            {
                await TechService.CreateTech(TechDto);
                NavigationManager.NavigateTo("/");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
