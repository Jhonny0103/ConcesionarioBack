using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConcesionarioBack.Entities
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        [Column("CustomerId")]
        public int CustomerId { get; set; }
        [Column("FirstName")]
        public string FirstName { get; set; } = string.Empty;
        [Column("LastName")]
        public string LastName { get; set; } = string.Empty;
        [Column("Email")]
        public string Email { get; set; } = string.Empty;
        [Column("PhoneNumber")]
        public string PhoneNumber { get; set; } = string.Empty;

        // La columna CreatedDate establece la fecha y hora en el momento del registro.
        [Column("CreatedDate")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        // La columna IsActive estable automaticamente true 1.
        [Column("IsActive")]
        public bool IsActive { get; set; } = true;
    }
}
