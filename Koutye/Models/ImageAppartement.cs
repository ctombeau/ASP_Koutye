namespace Koutye.Models
{
    public class ImageAppartement
    {
        public int id { get; set; }
        public string description_image { get; set; }
        public string image { get; set;}
        public virtual Appartement appartement { get; set; }
    }
}
