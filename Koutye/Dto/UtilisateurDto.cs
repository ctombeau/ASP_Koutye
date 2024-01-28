using Koutye.Models;
using System.ComponentModel.DataAnnotations;

namespace Koutye.Dto
{
    public class UtilisateurDto
    {
        public int utilisateurId { get; set; }

        [Required]
        public string nom { get; set; }

        [Required]
        public string prenom { get; set; }

        [Required]
        public string username { get; set; }

        [Required]
        public string email { get; set; }

        [Required]
        public string password { get; set; }

        public string? photo { get; set; }
        public string? phone { get; set; }

        public DateTime? modificationDate { get; set; }

        public DateTime? login_date { get; set; }

        public DateTime? logoutDate { get; set; }

        public virtual string type { get; set; }

    }
}
