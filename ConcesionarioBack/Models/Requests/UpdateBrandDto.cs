namespace ConcesionarioBack.Models.Requests
{
    public class UpdateBrandDto
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; } = string.Empty;
    }
}
