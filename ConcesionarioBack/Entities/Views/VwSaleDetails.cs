using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConcesionarioBack.Entities.Views
{
    [Table("vw_SalesDetails")]
    public class VwSaleDetails
    {
        [Key]
        [Column("SaleId")]
        public int SaleId { get; set; }
        [Column("VehicleId")]
        public int VehicleId { get; set; }
        [Column("ModelId")]
        public int ModelId { get; set; }
        [Column("ModelName")]
        public string ModelName { get; set; } = string.Empty;
        [Column("BrandId")]
        public int BrandId { get; set; }
        [Column("BrandName")]
        public string BrandName { get; set; } = string.Empty;
        [Column("LicensePlate")]
        public string LicensePlate { get; set; } = string.Empty;
        [Column("CustomerId")]
        public int CustomerId { get; set; }
        [Column("FirstName")]
        public string FirstName { get; set; } = string.Empty;
        [Column("LastName")]
        public string LastName { get; set; } = string.Empty;
        [Column("SaleDate")]
        public DateTime SaleDate { get; set; }
        [Column("SalePrice")]
        public decimal SalePrice { get; set; }
    }
}
