using DeveloperPortfolio.Models.Dtos;
using DeveloperPortfolio.Web.Services.Contracts;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text;

namespace DeveloperPortfolio.Web.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient httpClient;

        public CategoryService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<CategoryDto>> GetAllCategories()
        {
            try
            {
                var response = await httpClient.GetAsync("api/Category");

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return Enumerable.Empty<CategoryDto>();
                    }

                    return await response.Content.ReadFromJsonAsync<IEnumerable<CategoryDto>>();
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

        public async Task<CategoryDto> GetCategory(int id)
        {
            try
            {
                var response = await httpClient.GetAsync($"api/Category/{id}");

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default(CategoryDto);
                    }

                    return await response.Content.ReadFromJsonAsync<CategoryDto>();
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

        public async Task<CategoryDto> CreateCategory(CategoryDto categoryDto)
        {
            try
            {
                var response = await httpClient.PostAsJsonAsync($"api/Category", categoryDto);

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default(CategoryDto);
                    }

                    return await response.Content.ReadFromJsonAsync<CategoryDto>();
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

        public async Task<CategoryDto> DeleteCategory(int id)
        {
            try
            {
                var response = await httpClient.DeleteAsync($"api/Category/{id}");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<CategoryDto>();
                }

                return default(CategoryDto);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<CategoryDto> UpdateCategory(CategoryDto categoryDto)
        {
            try
            {
                var jsonRequest = JsonConvert.SerializeObject(categoryDto);
                var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json-put+json");

                var response = await httpClient.PutAsync($"api/Category/{categoryDto.Id}", content);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<CategoryDto>();
                }

                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
