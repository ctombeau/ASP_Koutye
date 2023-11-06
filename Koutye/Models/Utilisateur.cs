namespace Koutye.Models
{
    public class Utilisateur
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public string photo { get; set; }
        public string phone { get; set; }
        public DateTime modificationDate { get; set; }
        public DateTime login_date { get; set; }

        public DateTime logoutDate { get; set; }

        public virtual TypeUtilisateur typeUtilisateur { get; set; }

        public IEnumerable<Appartement> appartements { get; set;}
    }
}
