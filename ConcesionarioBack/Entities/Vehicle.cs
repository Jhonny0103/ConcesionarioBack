using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConcesionarioBack.Entities
{
    [Table("Vehicles")]
    public class Vehicle
    {
        [Key]
        [Column("VehicleId")]
        public int VehicleId { get; set; }
        [Column("ModelId")]
        public int ModelId { get; set; }
        [Column("LicensePlate")]
        public string LicensePlate { get; set; } = string.Empty;
        [Column("Color")]
        public string Color { get; set; } = string.Empty;
        [Column("Year")]
        public int Year { get; set; }
        [Column("Price")]
        public decimal Price { get; set; }
        // La columna CreatedDate establece la fecha y hora en el momento del registro.
        [Column("CreatedDate")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [Column("IsSold")]
        public bool IsSold { get; set; } = false;

        // La columna IsActive estable automaticamente true 1.
        [Column("IsActive")]
        public bool IsActive { get; set; } = true;
    }
}
