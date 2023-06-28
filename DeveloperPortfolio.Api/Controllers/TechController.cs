﻿using DeveloperPortfolio.Api.Extensions;
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

        [HttpPost]
        public async Task<ActionResult<TechDto>> CreateTech([FromBody] TechDto techDto)
        {
            try
            {
                var newTech = await techRepository.CreateTech(techDto);

                if (newTech == null)
                {
                    return NoContent();
                }

                var newTechDto = newTech.ConvertToDto();

                return CreatedAtAction(nameof(GetTech), new { id = newTechDto.Id }, newTechDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<TechDto>> UpdateTech(int id, TechDto techDto)
        {
            try
            {
                var tech = await techRepository.UpdateTech(id, techDto);

                if (tech == null)
                {
                    return NotFound();
                }

                var newTechDto = tech.ConvertToDto();

                return Ok(newTechDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<TechDto>> DeleteTech(int id)
        {
            try
            {
                var tech = await techRepository.DeleteTech(id);

                if (tech == null)
                {
                    return NotFound();
                }

                var techDto = tech.ConvertToDto();

                return Ok(techDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }            
        }
    }
}
