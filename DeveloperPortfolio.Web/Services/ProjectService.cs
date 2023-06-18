using DeveloperPortfolio.Models.Dtos;
using DeveloperPortfolio.Web.Services.Contracts;
using System.Net.Http.Json;

namespace DeveloperPortfolio.Web.Services
{
    public class ProjectService : IProjectService
    {
        private readonly HttpClient httpClient;

        public ProjectService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<ProjectDto>> GetAllProjects()
        {
            try
            {
                var projects = await this.httpClient.GetFromJsonAsync<IEnumerable<ProjectDto>>("api/Project");
                return projects;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
