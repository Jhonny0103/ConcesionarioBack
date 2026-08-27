using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConcesionarioBack.Entities
{
    [Table("Employees")]
    public class Employe
    {
        [Key]
        [Column("EmployeId")]
        public int EmployeId { get; set; }
        [Column("EmployeName")]
        public string EmployeName { get; set; } = string.Empty;
        [Column("EmployeEmail")]
        public string EmployeEmail { get; set; } = string.Empty;
        [Column("EmployePhone")]
        public string EmployePhone { get; set; } = string.Empty;
        [Column("CreatedDate")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [Column("IsActive")]
        public bool IsActive { get; set; } = true;
    }
}
