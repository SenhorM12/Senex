using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Senex.Models
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
        public string? Nome { get; set; }

        [Column("DOSG_REMEDIO")]
        public double? Dosagem { get; set; }

        [Column("COR_REMEDIO")]
        public string? Cor { get; set; }

        [Column("QNT_DIARIA")]
        public string? QntDiaria { get; set; }

    }
}
