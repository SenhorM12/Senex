using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FiapWebAPI.Models
{
    [Table("T_REMEDIO")]
    public class Remedio
    {
        [Key]
        [Column("ID_REMEDIO")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "/n *Obrigatório*")]
        [Column("NM_REMEDIO")]
        public String Nome { get; set; }

        [Column("DOSG_REMEDIO")]
        public Double? Dosagem { get; set; }

        [Column("COR_REMEDIO")]
        public String? Cor { get; set; }

        //Foreign Keys
        [Column("T_IDOSO_ID_IDOSO")]
        public int IdIdoso { get; set; }

        [Column("T_IDOSO_T_USR_LOGIN_USR")]
        public String LoginUsr { get; set; } 

    }
}
