namespace ConcesionarioBack.Models.Requests
{
    public class UpdateModelDto
    {
        public int ModelId { get; set; }
        public string ModelName { get; set; } = string.Empty;
    }
}
