using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Koutye.Models
{
    public class Appartement
    {
        [Key]
        [Column("appartement_id")]
        public int appartementId { get; set; }
        public string description { get; set; }
        public virtual Adresse adresse { get; set; }

        public virtual Utilisateur utilisateur { get; set; }

        public IEnumerable<ImageAppartement> imageAppartements { get; set; }

        public IEnumerable<VideoAppartement> videoAppartements { get; set; }

        public IEnumerable<Ferme> fermes { get; set; }

    }
}
