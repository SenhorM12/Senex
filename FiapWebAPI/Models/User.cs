using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Senex.Models
{
    [Table("T_USER")]
    public class User
    {
        [Key]
        [Required(ErrorMessage = "/n *Obrigatório*")]
        [Column("LOGIN_USR")]
        public string Login { get; set; }

        [Required(ErrorMessage = "/n *Obrigatório*")]
        [Column("SENHA_USR")]
        public string Password { get; set; }

        [Column("EMAIL_USR")]
        public string Email { get; set; }

        [Column("NOME_USR")]
        public string Nome { get; set; }

        [Column("TELEFONE_USR")]
        public int Telefone { get; set; }

    }
}
