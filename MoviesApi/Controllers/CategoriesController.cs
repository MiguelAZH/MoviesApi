using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesApi.DAL.Models.Dtos;
using MoviesApi.Services.IServices;

namespace MoviesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        [HttpGet(Name = "GetCaregoriesAsync")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ICollection<CategoryDto>>> GetCaregoriesAsync()
        {
            var categories = await _categoryService.GetCategoriesAsync();
            return Ok(categories);
        }

        [HttpGet("{id:int}", Name= "GetCategoryByIdAsync")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<CategoryDto>> GetCategoryByIdAsync(int id)
        {
            var CategoryDto = await _categoryService.GetCategoryByIdAsync(id);
            return Ok(CategoryDto);
        }

        [HttpPost(Name = "CreateCategoryAsync")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]

        public async Task<ActionResult<CategoryDto>> CreateCategoryAsync([FromBody] CategoryCreateDto categoryCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            try
            {
                var createdCategory = await _categoryService.CreateCategoryAsync(categoryCreateDto);
                return CreatedAtRoute(
                    "GetCategoryByIdAsync",     //1er parametro: nombre de la ruta
                    new { id = createdCategory.Id },    //2o parametro: los valores de los parametros de la ruta
                    createdCategory);       //3er parametro: el objeto creado
            }
            catch(InvalidOperationException ex) when (ex.Message.Contains("Ya existe"))
            {
                return Conflict(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            

        }
    }
}
