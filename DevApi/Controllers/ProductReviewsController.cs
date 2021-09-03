using Microsoft.AspNetCore.Mvc;

namespace DevApi.Controllers
{
    [ApiController]
    [Route("api/products/{productId}/productreviews")]
    public class ProductReviewsController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetById(int productId, int id) {
            return Ok();
        }
    }
}