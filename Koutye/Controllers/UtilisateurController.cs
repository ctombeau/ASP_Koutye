using Koutye.Dao;
using Koutye.Data;
using Koutye.Dto;
using Koutye.Models;
using Koutye.Utils;
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
        public IActionResult AddUser([FromBody] UtilisateurDto util)
        {
            UtilisateurDaoImpl utilDao = new UtilisateurDaoImpl();

            if (ModelState.IsValid) 
            {
                if(utilDao.findUtilisateurByUsername(util.username) == null && utilDao.findUtilisateurByEmail(util.email) == null)
                {
                   UtilisateurDto utilDto = utilDao.addUser(util);
                   return Ok(utilDto);
                }
                else
                {
                    Console.WriteLine("L'utilisateur existe deja");
                    //return Conflict();
                    return StatusCode(409);
                }
            }
            else
            {
                Console.WriteLine("Le modele n'est pas valide");
                return BadRequest();
            }
            
        }

        [HttpGet]
        [Route("/file")]
        public Task<String> uploadFile(IFormFile file)
        {
            FileUpload fileUpload = new FileUpload();
            return fileUpload.uploadFile(file);
        }

        [HttpGet]
        [Route("user")]
        public IActionResult findUser(String username)
        {
            UtilisateurDaoImpl utilDaoImpl = new UtilisateurDaoImpl();
            Utilisateur util = new Utilisateur();

            util = utilDaoImpl.findUtilisateurByUsername(username);

            if (util != null)
                return Ok(util);
            else
                return NotFound();
        }
    }
}
