using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL_FACTURA.Models
{
    [Table("Cliente", Schema = "dbo")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idCliente { get; set; }

        [Required]
        [Display(Name = "nombreCliente")]
        public string nombreCliente { get; set; }

        [Required]
        [Display(Name = "edadCliente")]
        public int edadCliente { get; set; }

    }
}
