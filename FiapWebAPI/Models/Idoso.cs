using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Senex.Models
{
    [Table("T_PROTEGIDO")]
    public class Idoso
    {
        [Key]
        [Column("ID_PROTEGIDO")]
        [Required(ErrorMessage = "/n *Obrigatório*")]
        public int Cpf { get; set; }

        [Column("NM_PROTEGIDO")]
        [Required(ErrorMessage = "/n *Obrigatório*")]
        public string Nome { get; set; }

        [Column("ENDR_PROTEGIDO")]
        public string Endereco { get; set; }

        [Column("DT_NASC_PROTEGIDO")]
        public string? Dt_nasc { get; set; }
    }
}
