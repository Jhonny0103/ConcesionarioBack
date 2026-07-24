using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConcesionarioBack.Entities
{
    [Table("Sales")]
    public class Sale
    {
        [Key]
        [Column("SaleId")]
        public int SaleId { get; set; }
        [Column("VehicleId")]
        public int VehicleId { get; set; }
        [Column("CustomerId")]
        public int CustomerId { get; set; }
        [Column("SaleDate")]
        public DateTime SaleDate { get; set; } = DateTime.Now;
        [Column("SalePrice")]
        public decimal SalePrice { get; set; }
    }
}
