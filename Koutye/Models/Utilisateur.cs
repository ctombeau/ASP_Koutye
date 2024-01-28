using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Koutye.Models
{
    [Index(nameof(username),nameof(email), IsUnique = true)]
    public class Utilisateur
    {
        [Key]
        [Column("utilisateur_id")]
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

        public DateTime? creationDate { get; set; }

       // [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? modificationDate { get; set; }

       // [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? login_date { get; set; }

        public DateTime? logoutDate { get; set; }

        public virtual TypeUtilisateur? typeUtilisateur { get; set; }

        public IEnumerable<Appartement>? appartements { get; set;}
    }
}
