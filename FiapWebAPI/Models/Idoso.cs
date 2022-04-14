using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FiapWebAPI.Models
{
    [Table("T_IDOSO")]
    public class Idoso
    {
        [Key]
        [Column("CPF_IDOSO")]
        [Required(ErrorMessage = "/n *Obrigatório*")]
        public int Cpf { get; set; }

        [Column("NM_IDOSO")]
        [Required(ErrorMessage = "/n *Obrigatório*")]
        public String Nome { get; set; }

        [Column("DT_NASC_IDOSO")]
        public DateTime Dt_nasc { get; set; }

        [Column("ENDR_IDOSO")]
        public String Endereco { get; set; }

    }
}
