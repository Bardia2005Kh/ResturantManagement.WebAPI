using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResturantManagement.Models.DTOs.CategoryDTOs;
using ResturantManagement.Models.Entities;
using ResturantManagement.Repository.Interfaces;

namespace ResturantManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IMapper mapper;

        public CategoriesController(ICategoryRepository categoryRepository, IMapper mapper)
        {
            this.categoryRepository = categoryRepository;
            this.mapper = mapper;
        }



        // POST
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddCategoryDto addCategoryDto)
        {
            var categoryDomain = mapper.Map<Category>(addCategoryDto);
            categoryDomain = await categoryRepository.CreateAsync(categoryDomain);

            var categoryDto = mapper.Map<CategoryDto>(categoryDomain);
            return Ok(categoryDto);
        }

        // GET
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categoriyDomain = await categoryRepository.GetAllAsync();
            var categoryDto = mapper.Map<List<CategoryWithMenuItemDto>>(categoriyDomain);
            return Ok(categoryDto);
        }

        // GET BY ID
        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var categoryDomain = await categoryRepository.GetByIdAsync(id);

            var categoryDto = mapper.Map<CategoryDto>(categoryDomain);

            return Ok(categoryDto);
        }

        // PUT
        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Update([FromRoute] int id, Category category)
        {
            var categoryDomain = await categoryRepository.UpdateAsync(id, category);
            if (categoryDomain == null)
            {
                return NotFound();
            }

            var categoryDto = mapper.Map<CategoryDto>(categoryDomain);

            return Ok(categoryDto);
        }

        // DELETE
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var categoryDomain = await categoryRepository.DeleteAsync(id);
            if (categoryDomain == null)
            {
                return NotFound();
            }

            var categoryDto = mapper.Map<CategoryDto>(categoryDomain);

            return Ok(categoryDto);
        }
    }
}
