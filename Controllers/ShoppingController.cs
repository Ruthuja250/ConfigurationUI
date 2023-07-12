using Microsoft.AspNetCore.Mvc; 
using Microsoft.AspNetCore.Http;
using ConfigurationUI.Repository;

namespace ConfigurationUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class ShoppingController : Controller    
    {
        readonly IDataAccess dataAccess;
        private readonly string DateFormat;
        public ShoppingController(IDataAccess dataAccess,IConfiguration configuration)
        {
            this.dataAccess = dataAccess;
            DateFormat = configuration["Constants:DateFormat"];
        }

        // loading category and subcategory list
        [HttpGet("GetCategoryList")]
        public IActionResult GetCategoryList()
        {
            var result = dataAccess.GetProductCategories();
            return Ok(result);
        }

        // loading products by category , subcategory
        [HttpGet("GetProducts")]
        public IActionResult GetProducts(string category , string subcategory,int count)
        {
            var result =dataAccess.GetProducts(category, subcategory, count);   
            return Ok(result);

        } 

        // load products by there id
        [HttpGet("GetProduct/{id}")]
        public IActionResult GetProduct(int id)
        {
            var result =dataAccess.GetProduct(id);   
            return Ok(result);

        } 


    }

}