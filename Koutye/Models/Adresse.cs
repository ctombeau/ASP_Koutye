namespace Koutye.Models
{
    public class Adresse
    {
        public int id { get; set; }
        public int numero { get; set; }
        public string commune { get; set; }
        public string departement { get; set; }
        public string pays { get; set; }
        public string rue { get; set; }
        public IEnumerable<Appartement> appartements {get;set;}
    }
}
