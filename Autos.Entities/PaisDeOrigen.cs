using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autos.Entities
{
    [Table("PaisesDeOrigen")]
    public partial class PaisDeOrigen
    {
        [Key]
        public int PaisDeOrigenId { get; set; }

        [Required]
        [StringLength(100)]
        public string NombrePais { get; set; }
    }
}
