using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autos.Entities
{
    [Table("Provincias")]
    public class Provincia
    {
        public int ProvinciaId { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
