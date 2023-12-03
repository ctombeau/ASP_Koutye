using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Koutye.Models
{
    public class Ferme
    {
        [Key]
        [Column("ferme_id")]
        public int fermeId { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime debut { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime fin { get; set; }

        [Required]
        public double montant { get; set; }
        public IEnumerable<Appartement> appartements { get; set;}
    }
}
