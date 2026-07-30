namespace ConcesionarioBack.Models.Requests
{
    public class CreateSaleDto
    {
        public int VehicleId { get; set; }
        public int CustomerId { get; set; }
        public decimal SalePrice { get; set; }
    }
}
