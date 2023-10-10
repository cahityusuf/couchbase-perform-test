using cb_perform_test.Models;
using cb_perform_test.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace cb_perform_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductDetailService _productDetailService;

        public ProductController(IProductDetailService productDetailService)
        {
            _productDetailService = productDetailService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string id)
        {
            var result = await _productDetailService.Get(id);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Set([FromBody] ProductDetailWebModel productDetailWebModel)
        {
            var result = await _productDetailService.Set(productDetailWebModel);

            return Ok(result);
        }

        [HttpPost("test")]
        public async Task<IActionResult> Test([FromBody] ProductDetailWebModel productDetailWebModel)
        {
            var result = await _productDetailService.Test(productDetailWebModel);

            return Ok(result);
        }
    }
}
