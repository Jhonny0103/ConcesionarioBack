using ConcesionarioBack.Entities;
using ConcesionarioBack.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConcesionarioBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private SalesService service;
        public SalesController(SalesService service)
        {
            this.service = service;
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<List<Sale>>> GetSalesAsync()
        {
            var sales = await service.GetSalesAsync();
            return Ok(sales);
        }
    }
}
