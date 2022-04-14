using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FiapWebAPI.Models
{
        [Table("T_POSOLOGIA")]
        public class Posologia
        {
  
            [Key]
            [Column("ID_POSOLOGIA")]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }

            [Column("HR_POSOLOGIA")]
            public DateTime Hora { get; set; }

            [Column("QUANT_POSOLOGIA")]
            public int Quantidade { get; set; }

            [Column("TP_POSOLOGIA")]
            public String Tipo { get; set; } 

        }
}
