using DeveloperPortfolio.Models.Dtos;
using DeveloperPortfolio.Web.Services.Contracts;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text;

namespace DeveloperPortfolio.Web.Services
{
    public class TechService : ITechService
    {
        private readonly HttpClient httpClient;

        public TechService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
               

        public async Task<IEnumerable<TechDto>> GetAllTechs()
        {
            try
            {
                var response = await httpClient.GetAsync("api/Tech");

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return Enumerable.Empty<TechDto>();
                    }

                    return await response.Content.ReadFromJsonAsync<IEnumerable<TechDto>>();
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

        public async Task<TechDto> GetTech(int id)
        {
            try
            {
                var response = await httpClient.GetAsync($"api/Tech/{id}");

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default(TechDto);
                    }

                    return await response.Content.ReadFromJsonAsync<TechDto>();
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

        public async Task<TechDto> CreateTech(TechDto techDto)
        {
            try
            {
                var response = await httpClient.PostAsJsonAsync($"api/Tech", techDto);

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default(TechDto);
                    }

                    return await response.Content.ReadFromJsonAsync<TechDto>();
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

        public async Task<TechDto> DeleteTech(int id)
        {
            try
            {
                var response = await httpClient.DeleteAsync($"api/Tech/{id}");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<TechDto>();
                }

                return default(TechDto);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<TechDto> UpdateTech(TechDto techDto)
        {
            try
            {
                var jsonRequest = JsonConvert.SerializeObject(techDto);
                var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json-put+json");

                var response = await httpClient.PutAsync($"api/Tech/{techDto.Id}", content);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<TechDto>();
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
