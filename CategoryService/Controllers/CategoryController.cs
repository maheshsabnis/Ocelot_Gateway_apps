using CategoryService.Models;
using CategoryService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CategoryService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        CategoryRepoService catServ;

        public CategoryController(CategoryRepoService catServ)
        {
            this.catServ = catServ;
        }

        [HttpGet]
        public IActionResult Get() 
        {
            var response = catServ.GetCategories();
            return Ok(response);
        }
 

        [HttpPost]
        public  IActionResult Post(Category c)
        {
            var result =  catServ.AddCategory(c);
            return Ok(result);
        }

        

    }
}
