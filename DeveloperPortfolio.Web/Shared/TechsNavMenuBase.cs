using DeveloperPortfolio.Models.Dtos;
using DeveloperPortfolio.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace DeveloperPortfolio.Web.Shared
{
    public class TechsNavMenuBase : ComponentBase
    {
        [Inject]
        public ITechService TechService { get; set; }

        public IEnumerable<TechDto> TechDtos { get; set; }

        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                TechDtos = await TechService.GetAllTechs();
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }
    }
}
