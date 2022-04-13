using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FiapWebAPI.Models
{
    [Table("T_USR")]
    public class User
    {
        [Key]
        [Required(ErrorMessage = "/n *Obrigatório*")]
        [Column("LOGIN_USR")]
        public String Login { get; set; }

        [Required(ErrorMessage = "/n *Obrigatório*")]
        [Column("SENHA_USR")]
        public String Password { get; set; }

        [Column("EMAIL_USR")]
        public String Email { get; set; }

        [Column("NOME_USR")]
        public String Nome { get; set; }

        [Column("CONTATO_USR")]
        public int Contato { get; set; }

    }
}
