using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autos.Entities
{
    [Table("Marcas")]
    public  class Marca
    {
        public Marca()
        {
            Autos = new HashSet<Auto>();
        }

        public int MarcaId { get; set; }

        [Required]
        [StringLength(50)]
        public string NombreMarca { get; set; }

        public virtual ICollection<Auto> Autos { get; set; }
    }
}
