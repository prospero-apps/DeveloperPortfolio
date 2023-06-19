using DeveloperPortfolio.Api.Extensions;
using DeveloperPortfolio.Api.Repositories;
using DeveloperPortfolio.Api.Repositories.Contracts;
using DeveloperPortfolio.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeveloperPortfolio.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TechController : ControllerBase
    {
        private readonly ITechRepository techRepository;

        public TechController(ITechRepository techRepository)
        {
            this.techRepository = techRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TechDto>>> GetAllTechs()
        {
            try
            {
                var techs = await techRepository.GetAllTechs();

                if (techs == null)
                {
                    return NotFound();
                }
                else
                {
                    var techDtos = techs.ConvertToDto();
                    return Ok(techDtos);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<TechDto>> GetTech(int id)
        {
            try
            {
                var tech = await techRepository.GetTech(id);

                if (tech == null)
                {
                    return BadRequest();
                }
                else
                {
                    var techDto = tech.ConvertToDto();
                    return Ok(techDto);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
