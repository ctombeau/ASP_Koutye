using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Koutye.Models
{
    public class VideoAppartement
    {
        [Key]
        [Column("video_id")]
        public int videoId { get; set; }
        public string description_video { get; set; }
        public string video { get; set;}
        public virtual Appartement appartement { get; set; }
    }
}
