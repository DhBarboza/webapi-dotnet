using DevApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevApi.Controllers
{
    // Anotações:
    [ApiController]
    [Route("api/[controller]")]

    // Class herdada de "controller base"
    public class ProductsController : ControllerBase
    {
        //Anotação de método:
        [HttpGet]
        public IActionResult GetAll() {
            return Ok();
        }

        // api/products/{id}
        [HttpGet("{id}")]
        public IActionResult GetById(int id) {
            return Ok();
        }

        // api/products
        [HttpPost]
        public IActionResult Post(AddProductInputModel model) {
            return CreatedAtAction(nameof(GetById), new { id = 1 }, model);
        }

        // api/products/{id}
        [HttpPut("{id}")]
        public IActionResult Put(UpdateProductInputModel model) {
            return NoContent();
        }
    }
}