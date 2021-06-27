using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autos.Entities
{
    [Table("Autos")]
    public class Auto
    {
        public int AutoId { get; set; }

        public int MarcaId { get; set; }

        [Required]
        [StringLength(20)]
        public string Modelo { get; set; }

        public decimal PrecioFinal { get; set; }

        //[Required]
        //[StringLength(50)]
        //public string PaisDeOrigen { get; set; }

        [Required]
        public int PaisDeOrigenId { get; set; }

        public int TipoDeVehiculoId { get; set; }

        public virtual Marca Marca { get; set; }

        public virtual TipoDeVehiculo TipoDeVehiculo { get; set; }

        public virtual PaisDeOrigen PaisDeOrigen { get; set; }
    }
}
