using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autos.Entities
{
    [Table("Sucursales")]
    public class Sucursal
    {
        [Key]
        public int SucursalId { get; set; }

        [Required]
        [StringLength(50)]
        public string NombreSucursal { get; set; }

        [StringLength(100)]
        public string Calle { get; set; }

        [StringLength(10)]
        public string Altura { get; set; }

        [StringLength(100)]
        public string Entre1 { get; set; }

        [StringLength(100)]
        public string Entre2 { get; set; }

        public int LocalidadId { get; set; }

        public int ProvinciaId { get; set; }

        [StringLength(10)]
        public string CodigoPostal { get; set; }

        [StringLength(20)]
        public string TelefonoFijo { get; set; }

        [StringLength(20)]
        public string TelefonoMovil { get; set; }

        [StringLength(120)]
        public string CorreoElectronico { get; set; }
    }
}
