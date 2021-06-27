using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autos.Entities
{
    [Table("Ventas")]
    public class Venta
    {
        [Key]
        public int VentaId { get; set; }

        [Required]
        [StringLength(255)]
        public string Patente { get; set; }

        public int ClienteId { get; set; }

        public int VendedorId { get; set; }

        public DateTime FechaOperación { get; set; }

        [Column(TypeName = "money")]
        public decimal Monto { get; set; }

        public decimal Comision { get; set; }

        public int? AutoId { get; set; }

        [Required]
        public int? SucursalId { get; set; }

        public virtual Sucursal Sucursal { get; set; }

    }
}
