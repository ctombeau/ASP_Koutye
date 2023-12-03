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
  "logoutDate": null
  
}
 
 */

    public class UtilisateurController : Controller
    {
        KoutyeContext context = new KoutyeContext();
        [HttpPost]
        [Route("/user/add")]
        [Produces("application/json")]
        public Utilisateur AddUser([FromBody] Utilisateur util)
        {
            Console.WriteLine(util.username);
            //context.Utilisateurs.Add(util);
            //context.SaveChanges();
            //return util;
            //return View();
            return new UtilisateurDao().addUser(util);
        }
    }
}
