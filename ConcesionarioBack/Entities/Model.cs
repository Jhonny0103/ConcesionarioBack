using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConcesionarioBack.Entities
{
    [Table("Models")]
    public class Model
    {
        [Key]
        [Column("ModelId")]
        public int ModelId { get; set; }
        [Column("ModelName")]
        public string ModelName { get; set; } = string.Empty;

        // La columna CreatedDate establece la fecha y hora en el momento del registro.
        [Column("CreatedDate")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        // La columna IsActive estable automaticamente true 1.
        [Column("IsActive")]
        public bool IsActive { get; set; } = true;
    }
}
