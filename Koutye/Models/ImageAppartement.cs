using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Koutye.Models
{
    public class ImageAppartement
    {
        [Key]
        [Column("image_id")]
        public int imageId { get; set; }
        public string description_image { get; set; }
        public string image { get; set;}
        public virtual Appartement appartement { get; set; }
    }
}
