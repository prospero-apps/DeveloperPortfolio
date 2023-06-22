using DeveloperPortfolio.Api.Entities;
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
        private readonly ICategoryRepository categoryRepository;
        private readonly ITechRepository techRepository;        

        public ProjectController(IProjectRepository projectRepository, ICategoryRepository categoryRepository,
            ITechRepository techRepository)
        {
            this.projectRepository = projectRepository;
            this.categoryRepository = categoryRepository;
            this.techRepository = techRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProjectDto>>> GetAllProjects()
        {
            try
            {
                var projects = await projectRepository.GetAllProjects();
                var categories = await categoryRepository.GetAllCategories();
                var techs = await techRepository.GetAllTechs();
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
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
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
                    var category = await categoryRepository.GetCategory(project.CategoryId);
                    var techs = await projectRepository.GetProjectTechs(project.Id);
                    var links = await projectRepository.GetProjectLinks(project.Id);
                    var relations = await projectRepository.GetAllProjectTechRelations();

                    var projectDto = project.ConvertToDto(category, techs, links, relations);
                    return Ok(projectDto);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<ProjectDto>> CreateProject([FromBody] ProjectDto projectDto)
        {
            try
            {
                var newProject = await projectRepository.CreateProject(projectDto);

                if (newProject == null)
                {
                    return NoContent();
                }

                var category = await categoryRepository.GetCategory(newProject.CategoryId);


                var techs = await projectRepository.GetProjectTechs(newProject.Id);
                var links = await projectRepository.GetProjectLinks(newProject.Id);
                var relations = await projectRepository.GetAllProjectTechRelations();                               

                var newProjectDto = newProject.ConvertToDto(category, techs, links, relations);

                return CreatedAtAction(nameof(GetProject), new { id = newProjectDto.Id }, newProjectDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
