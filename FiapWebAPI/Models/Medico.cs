using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FiapWebAPI.Models
{
    public class Medico
    {  
        [Key]
        [Column("CRM_MED")]
        [Required(ErrorMessage = "/n *Obrigatório*")]
        public int Crm { get; set; }

        [Column("NM_MED")]
        [Required(ErrorMessage = "/n *Obrigatório*")]
        public String Nome { get; set; }

        [Column("CONTATO_MED")]
        public int? Contato { get; set; }
        
    }

}
