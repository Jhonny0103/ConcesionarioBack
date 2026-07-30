using ConcesionarioBack.Entities;
using ConcesionarioBack.Models.Requests;
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

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<ActionResult<Sale>> GetSaleByIdAsync(int id)
        {
            var sale = await service.GetSaleByIdAsync(id);
            return Ok(sale);
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult<Sale>> CreateSaleAsync(CreateSaleDto sale)
        {
            var newSale = await service.CreateSaleAsync(sale);
            return Ok(newSale);
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult<Sale>> UpdateSaleAsync(UpdateSaleDto sale)
        {
            var updatedSale = await service.UpdateSaleAsync(sale);
            return Ok(updatedSale);
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public async Task<ActionResult<bool>> DeleteSaleAsync(int id)
        {
            var result = await service.DeleteSaleAsync(id);
            return Ok(result);
        }
    }
}
