using Koutye.Dao;
using Koutye.Data;
using Koutye.Dto;
using Koutye.Models;
using Microsoft.AspNetCore.Mvc;


namespace Koutye.Controllers
{

    /*
    {
     "nom": "TOMBEAU",
     "prenom": "Chrisnor",
     "username": "ctombeau",
     "email": "tombeauc@gmail.com",
     "password": "Edma1988",
     "photo": "",
     "phone": "38051274",
     "modificationDate": null,
     "login_date": null,
     "logoutDate": null,
     "typeUtilisateur": "Proprietaire",
   }

    */

    public class UtilisateurController : Controller
    {
        KoutyeContext context = new KoutyeContext();
        [HttpPost]
        [Route("/user/add")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public Utilisateur AddUser([FromBody] UtilisateurDto util)
        {
            Console.WriteLine(util.nom);
            Console.WriteLine(util.prenom);
            Console.WriteLine(util.username);
            Console.WriteLine(util.password);
            Console.WriteLine(util.email);
            Console.WriteLine(util.phone);
            Console.WriteLine(util.type);
            
            
            if(ModelState.IsValid) 
            {
                Console.WriteLine(util.ToString());
                UtilisateurDaoImpl utilDao = new UtilisateurDaoImpl();
                utilDao.addUser(util);
            }
            else
            {
                Console.WriteLine("Le modele n'est pas valide");
            }
            

            

            return null;
        }
    }
}
