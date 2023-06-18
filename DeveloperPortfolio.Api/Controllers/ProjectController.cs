using DeveloperPortfolio.Api.Extensions;
using DeveloperPortfolio.Api.Repositories.Contracts;
using DeveloperPortfolio.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeveloperPortfolio.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectRepository projectRepository;

        public ProjectController(IProjectRepository projectRepository)
        {
            this.projectRepository = projectRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProjectDto>>> GetAllProjects()
        {
            try
            {
                var projects = await this.projectRepository.GetAllProjects();
                var categories = await this.projectRepository.GetAllCategories();
                var techs = await this.projectRepository.GetAllTechs();
                var links = await this.projectRepository.GetAllLinks();
                var relations = await this.projectRepository.GetAllProjectTechRelations();

                if (projects == null || categories == null || techs == null || links == null || relations == null)
                {
                    return NotFound();
                }
                else
                {
                    var projectDtos = projects.ConvertToDto(categories, techs, links, relations);
                    return Ok(projectDtos);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
    }
}
