namespace Koutye.Models
{
    public class Ferme
    {
        public int id { get; set; }
        public DateOnly debut { get; set; }
        public DateOnly fin { get; set; }

        public double montant { get; set; }
        public IEnumerable<Appartement> appartements { get; set;}
    }
}
