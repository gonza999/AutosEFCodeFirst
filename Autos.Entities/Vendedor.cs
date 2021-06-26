using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autos.Entities
{
    [Table("Vendedores")]
    public class Vendedor
    {
        [Key]
        public int VendedorId { get; set; }

        [Required]
        [StringLength(255)]
        public string NombreyApellido { get; set; }

        [StringLength(255)]
        public string Telefono { get; set; }

        //[StringLength(255)]
        //public string Categoria { get; set; }

        [Required]
        public int CategoriaDeVendedorId { get; set; }
        public virtual CategoriaDeVendedor CategoriaDeVendedor { get; set; }
    }
}
