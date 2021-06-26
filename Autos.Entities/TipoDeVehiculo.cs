using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autos.Entities
{
    [Table("TiposDeVehiculos")]
    public class TipoDeVehiculo
    {
        public TipoDeVehiculo()
        {
            Autos = new HashSet<Auto>();
        }

        [Key]
        public int TipoDeVehiculoId { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        public virtual ICollection<Auto> Autos { get; set; }
    }
}
