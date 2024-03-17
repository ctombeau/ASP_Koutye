using Koutye.Dto;
using Koutye.Models;

namespace Koutye.Dao
{
    public interface UtilisateurDao
    {
        public UtilisateurDto addUser(UtilisateurDto utilisateur);
        public string cryptPassword(string password);
        public bool verifyPassword(string passwordBase,string passwordParameter);

       public Utilisateur findUtilisateurByUsername(string username);

       public Utilisateur findUtilisateurByEmail(string email);

        public int updateprofilePicture(IFormFile file, string username);
    }
}
