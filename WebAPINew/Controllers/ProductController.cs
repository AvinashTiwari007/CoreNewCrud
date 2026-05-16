using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPINew.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ProductController _context;
        public ProductController(ProductController context)
        {
            _context = context;
        }

        [HttpGet("GetEmpDetails")]
        public async Task<int> GetDetails()
        {
            return 100;
        }
    }
}
