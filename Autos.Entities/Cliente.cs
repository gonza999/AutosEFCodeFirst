using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autos.Entities
{
    [Table("Clientes")]
    public class Cliente
    {
        public int ClienteId { get; set; }

        [Required]
        [StringLength(255)]
        public string NombreApellido { get; set; }

        [StringLength(255)]
        public string Dirección { get; set; }

        [StringLength(255)]
        public string Localidad { get; set; }

        [StringLength(255)]
        public string Teléfono { get; set; }

        [StringLength(255)]
        public string Sexo { get; set; }

        public int? ProvinciaId { get; set; }

        public int? LocalidadId { get; set; }

        public int? SituacionIvaId { get; set; }
    }
}
