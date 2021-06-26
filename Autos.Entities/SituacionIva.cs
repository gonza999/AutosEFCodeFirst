using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autos.Entities
{
    [Table("SituacionesIva")]
    public class SituacionIva
    {
        [Key]
        public int SituacionIvaId { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }
    }
}
