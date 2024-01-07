using Koutye.Data;
using Koutye.Models;

namespace Koutye.Dao
{
    public class UtilisateurDaoImpl : UtilisateurDao
    {
        KoutyeContext koutyeContext = new KoutyeContext();
        public Utilisateur addUser(Utilisateur utilisateur) 
        {
            koutyeContext.Add(utilisateur);
            koutyeContext.SaveChanges();
            return utilisateur;
        }

    }
}
