using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Supermarket.Api.Domain.Models;
using Supermarket.Api.Domain.Services;
using Supermarket.Api.Resources;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Supermarket.Api.Controllers
{
    [Route("/api/[controller]")]
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<CategoryResource>> GetAllAsync()
        {
            var categories = await _categoryService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Category>, IEnumerable<CategoryResource>>(categories);

            return resources;
        }
    }
}
