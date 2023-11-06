namespace Koutye.Models
{
    public class ImageAppartement
    {
        public int id { get; set; }
        public string description_image { get; set; }
        public string image { get; set;}
        public Appartement appartement { get; set; }
    }
}
