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
            public TimeOnly Hora { get; set; }

            [Column("QUANT_POSOLOGIA")]
            public int Quantidade { get; set; }

            [Column("TP_POSOLOGIA")]
            public String Tipo { get; set; } 
            
            //Foreign Keys
            [Column("T_REMEDIO_ID_REMEDIO")]
            public int IdRemedio { get; set; }
            
            [Column("T_REMEDIO_ID_IDOSO")]
            public int IdIdoso { get; set; }

            [Column("T_REMEDIO_LOGIN_USR")]
            public String LoginUsr { get; set; }

        }
}
