using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos.Entities
{
    [Table("CategoriasDeVendedores")]
    public class CategoriaDeVendedor
    {
        [Key]
        public int CategoriaDeVendedorId { get; set; }

        [Required]

        [StringLength(50)]
        public string Descripcion { get; set; }
    }
}
