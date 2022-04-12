using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FiapWebAPI.Models
{
    [Table("T_RESP_FMLR")]
    public class Familiar
    {
        [Key]
        [Column("ID_RESP")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("NM_RESP")]
        public String Nome { get; set; }

        [Column("ENDR_RESP")]
        public String Address { get; set; }

    }
}
