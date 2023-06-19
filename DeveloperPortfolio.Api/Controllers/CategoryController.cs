using DeveloperPortfolio.Api.Extensions;
using DeveloperPortfolio.Api.Repositories;
using DeveloperPortfolio.Api.Repositories.Contracts;
using DeveloperPortfolio.Models.Dtos;
using DeveloperPortfolio.Web.Pages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeveloperPortfolio.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryDto>>> GetAllCategories()
        {
            try
            {
                var categories = await categoryRepository.GetAllCategories();
                                
                if (categories == null)
                {
                    return NotFound();
                }
                else
                {
                    var categoryDtos = categories.ConvertToDto();
                    return Ok(categoryDtos);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<CategoryDto>> GetCategory(int id)
        {
            try
            {
                var category = await categoryRepository.GetCategory(id);

                if (category == null)
                {
                    return BadRequest();
                }
                else
                {
                    var categoryDto = category.ConvertToDto();
                    return Ok(categoryDto);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        //[HttpPost]
        //[Route(nameof(CreateCategory))]
        //public async Task<ActionResult<CategoryDto>> CreateCategory([FromBody] CategoryDto categoryDto)
        //{
        //    try
        //    {
        //        var newCategory = await projectRepository.CreateCategory(categoryDto);

        //        if (newCategory == null)
        //        {
        //            return NoContent();
        //        }

        //        var newCategoryDto = newCategory.ConvertToDto();

        //        return CreatedAtAction(nameof(GetCategory), new { id = newCategoryDto.Id }, newCategoryDto);
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        //    }
        //}
    }    
}
