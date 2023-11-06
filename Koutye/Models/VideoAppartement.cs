namespace Koutye.Models
{
    public class VideoAppartement
    {
        public int id { get; set; }
        public string description_video { get; set; }
        public string video { get; set;}
        public Appartement appartement { get; set; }
    }
}
