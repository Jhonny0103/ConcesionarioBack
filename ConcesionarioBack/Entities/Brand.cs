using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConcesionarioBack.Entities
{
    // Brand = Marca
    [Table("Brands")]
    public class Brand
    {
        [Key]
        [Column("BrandId")]
        public int BrandId { get; set; }
        [Column("BrandName")]
        public string BrandName { get; set; } = string.Empty;
        
        // La columna CreatedDate establece la fecha y hora en el momento del registro.
        [Column("CreatedDate")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        // La columna IsActive estable automaticamente true 1.
        [Column("IsActive")]
        public bool IsActive { get; set; } = true;
    }
}
