using DeveloperPortfolio.Models.Dtos;
using Microsoft.AspNetCore.Components;

namespace DeveloperPortfolio.Web.Components
{
    public class DisplayProjectsBase : ComponentBase
    {
        [Parameter]
        public IEnumerable<ProjectDto> Projects { get; set; }
    }
}
