namespace Koutye.Models
{
    public class Appartement
    {
        public int id { get; set; }
        public string description { get; set; }
        public Adresse adresse { get; set; }

        public Utilisateur utilisateur { get; set; }

        public IEnumerable<ImageAppartement> imageAppartements { get; set; }

        public IEnumerable<VideoAppartement> videoAppartements { get; set; }

        public IEnumerable<Ferme> fermes { get; set; }

    }
}
