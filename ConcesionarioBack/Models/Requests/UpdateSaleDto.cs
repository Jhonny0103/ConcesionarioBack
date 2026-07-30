namespace ConcesionarioBack.Models.Requests
{
    public class UpdateSaleDto
    {
        public int SaleId { get; set; }
        public int VehicleId { get; set; }
        public int CustomerId { get; set; }
        public decimal SalePrice { get; set; }
    }
}
