namespace Koutye.Models
{
    public class TypeUtilisateur
    {
        public int Id {  get; set; }
        public string nomType { get; set; }

        public IEnumerable<Utilisateur> utilisateurs { get; set; }
    }
}
