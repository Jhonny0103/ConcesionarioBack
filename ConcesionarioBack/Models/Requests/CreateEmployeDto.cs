namespace ConcesionarioBack.Models.Requests
{
    public class CreateEmployeDto
    {
        public string EmployeName { get; set; } = string.Empty;
        public string EmployeEmail { get; set; } = string.Empty;
        public string EmployePhone { get; set; } = string.Empty;
    }
}
