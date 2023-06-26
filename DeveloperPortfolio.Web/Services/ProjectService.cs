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
                var response = await httpClient.GetAsync("api/Project");

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return Enumerable.Empty<ProjectDto>();
                    }

                    return await response.Content.ReadFromJsonAsync<IEnumerable<ProjectDto>>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception(message);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<ProjectDto>> GetProjectsByCategory(int categoryId)
        {
            try
            {
                var response = await httpClient.GetAsync("api/Project/GetProjectsByCategory/{categoryId}");

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return Enumerable.Empty<ProjectDto>();
                    }

                    return await response.Content.ReadFromJsonAsync<IEnumerable<ProjectDto>>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception(message);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<ProjectDto>> GetProjectsByTech(int techId)
        {
            try
            {
                var response = await httpClient.GetAsync("api/Project/GetProjectsByTech/{techId}");

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return Enumerable.Empty<ProjectDto>();
                    }

                    return await response.Content.ReadFromJsonAsync<IEnumerable<ProjectDto>>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception(message);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ProjectDto> GetProject(int id)
        {
            try
            {
                var response = await httpClient.GetAsync($"api/Project/{id}");

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default(ProjectDto);
                    }

                    return await response.Content.ReadFromJsonAsync<ProjectDto>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception(message);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ProjectDto> CreateProject(ProjectDto projectDto)
        {
            try
            {
                var response = await httpClient.PostAsJsonAsync($"api/Project", projectDto);

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default(ProjectDto);
                    }

                    return await response.Content.ReadFromJsonAsync<ProjectDto>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception(message);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ProjectDto> DeleteProject(int id)
        {
            try
            {
                var response = await httpClient.DeleteAsync($"api/Project/{id}");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<ProjectDto>();
                }

                return default(ProjectDto);
            }
            catch (Exception)
            {
                throw;
            }
        }        
    }
}
