using Koutye.Dao;
using Koutye.Data;
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
        public Utilisateur AddUser(Utilisateur util)
        {
            Console.WriteLine(util.nom);
            /*
            if(ModelState.IsValid) 
            {
                Console.WriteLine(util.ToString());
            }
            else
            {
                Console.WriteLine("Le modele n'est pas valide");
            }
            */
            UtilisateurDaoImpl utilDao = new UtilisateurDaoImpl();
            utilDao.addUser(util);
             //context.Utilisateurs.Add(util);
            //context.SaveChanges();
            //return util;
            //return View();
            //return new UtilisateurDao().addUser(util);
            return null;
        }
    }
}
