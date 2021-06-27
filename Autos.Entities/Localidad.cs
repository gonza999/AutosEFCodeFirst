using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autos.Entities
{
    [Table("Localidades")]
    public class Localidad
    {
        [Key]
        public int LocalidadId { get; set; }

        public int ProvinciaId { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
