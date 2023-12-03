using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Koutye.Models
{
    public class TypeUtilisateur
    {
        [Key]
        [Column("type_id")]
        public int typeId {  get; set; }
        public string nomType { get; set; }

        public IEnumerable<Utilisateur> utilisateurs { get; set; }
    }
}
