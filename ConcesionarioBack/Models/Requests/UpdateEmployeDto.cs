namespace ConcesionarioBack.Models.Requests
{
    public class UpdateEmployeDto
    {
        public int EmployeId { get; set; }
        public string EmployeName { get; set; } = string.Empty;
        public string EmployeEmail { get; set; } = string.Empty;
        public string EmployePhone { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }
}
