using Koutye.Data;
using Koutye.Dto;
using Koutye.Models;

namespace Koutye.Dao
{
    public class UtilisateurDaoImpl : UtilisateurDao
    {
        KoutyeContext koutyeContext = new KoutyeContext();
        public UtilisateurDto addUser(UtilisateurDto utilisateurDto) 
        { 
            Utilisateur utilisateur = new Utilisateur();
            TypeUtilisateur typeUtilisateur = new TypeUtilisateur();

            utilisateurDto.password = this.cryptPassword(utilisateurDto.password);

            utilisateur.nom = utilisateurDto.nom;
            utilisateur.prenom = utilisateurDto.prenom;
            utilisateur.username = utilisateurDto.username;
            utilisateur.email = utilisateurDto.email;
            utilisateur.password = utilisateurDto.password;
            utilisateur.creationDate = DateTime.Now;
            utilisateur.phone = utilisateurDto.phone;
            utilisateur.photo = utilisateurDto.photo;
            utilisateur.actif = true;

            typeUtilisateur = koutyeContext.typeUtilisateur.FirstOrDefault(p=>p.nomType==utilisateurDto.type);
          
            utilisateur.typeUtilisateur = typeUtilisateur;
            try
            {
                koutyeContext.Add(utilisateur);
                koutyeContext.SaveChanges();
                return utilisateurDto;
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                return null;
            }
        }

  
        //install BCrypt.Net-Next
        public string cryptPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool verifyPassword(string passwordBase, string passwordParameter)
        {
            return BCrypt.Net.BCrypt.Verify(passwordBase, passwordParameter);
        }

        public Utilisateur findUtilisateurByEmail(string email)
        {
            Utilisateur util = koutyeContext.utilisateur.FirstOrDefault(u => u.email == email);
            return util;
        }

        public Utilisateur findUtilisateurByUsername(string username)
        {
            Utilisateur util = koutyeContext.utilisateur.FirstOrDefault(u=> u.username== username);
            return util;
        }
    }
}
