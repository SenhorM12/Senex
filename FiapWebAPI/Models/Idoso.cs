using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FiapWebAPI.Models
{
    [Table("T_IDOSO")]
    public class Idoso
    {
        [Key]
        [Column("CPF_IDOSO")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Cpf { get; set; }

        [Column("NM_IDOSO")]
        public String Nome { get; set; }

        [Column("DT_NASC_IDOSO")]
        public DateOnly Dt_nasc { get; set; }

        [Column("ENDR_IDOSO")]
        public String Endereco { get; set; }
    }
}
