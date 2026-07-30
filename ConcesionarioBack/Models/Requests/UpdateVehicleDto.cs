namespace ConcesionarioBack.Models.Requests
{
    public class UpdateVehicleDto
    {
        public int VehicleId { get; set; }
        public int ModelId { get; set; }
        public int BrandId { get; set; }
        public string LicensePlate { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public int Year { get; set; }
        public int Mileage { get; set; }
        public decimal Price { get; set; }
    }
}
