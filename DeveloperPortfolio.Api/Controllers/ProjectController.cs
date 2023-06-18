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
                var projects = await projectRepository.GetAllProjects();
                var categories = await projectRepository.GetAllCategories();
                var techs = await projectRepository.GetAllTechs();
                var links = await projectRepository.GetAllLinks();
                var relations = await projectRepository.GetAllProjectTechRelations();

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

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ProjectDto>> GetProject(int id)
        {
            try
            {
                var project = await projectRepository.GetProject(id);

                if (project == null)
                {
                    return BadRequest();
                }
                else
                {
                    var category = await projectRepository.GetCategory(project.CategoryId);
                    var techs = await projectRepository.GetProjectTechs(project.Id);
                    var links = await projectRepository.GetProjectLinks(project.Id);
                    var relations = await projectRepository.GetAllProjectTechRelations();


                    var projectDto = project.ConvertToDto(category, techs, links, relations);
                    return Ok(projectDto);
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
