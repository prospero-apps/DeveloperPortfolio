using DeveloperPortfolio.Models.Dtos;
using DeveloperPortfolio.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace DeveloperPortfolio.Web.Pages
{
    public class CreateTechBase : ComponentBase
    {
        public TechDto TechDto = new TechDto();

        [Inject]
        public ITechService TechService { get; set; }

        protected async void CreateTech_Submit()
        {
            try
            {
                await TechService.CreateTech(TechDto);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
