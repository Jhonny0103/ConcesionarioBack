using ConcesionarioBack.Entities;
using ConcesionarioBack.Models.Requests;
using ConcesionarioBack.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ConcesionarioBack.Services.Interfaces;

namespace ConcesionarioBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly ISalesService _service;
        public SalesController(ISalesService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<List<Sale>>> GetSalesAsync()
        {
            var sales = await _service.GetSalesAsync();
            return Ok(sales);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<ActionResult<Sale>> GetSaleByIdAsync(int id)
        {
            var sale = await _service.GetSaleByIdAsync(id);
            return Ok(sale);
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult<Sale>> CreateSaleAsync(CreateSaleDto sale)
        {
            var newSale = await _service.CreateSaleAsync(sale);
            return Ok(newSale);
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult<Sale>> UpdateSaleAsync(UpdateSaleDto sale)
        {
            var updatedSale = await _service.UpdateSaleAsync(sale);
            return Ok(updatedSale);
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public async Task<ActionResult<bool>> DeleteSaleAsync(int id)
        {
            var result = await _service.DeleteSaleAsync(id);
            return Ok(result);
        }
    }
}
