using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL_FACTURA.Models
{
    [Table("Venta", Schema = "dbo")]
    public class Venta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idVenta { get; set; }

        [Required]
        [Display(Name = "idFactura")]
        public int idFactura { get; set; }

        [Required]
        [Display(Name = "fechaVenta")]
        public DateTime fechaVenta { get; set; }

        [Required]
        [Display(Name = "idCliente")]
        public int idCliente { get; set; }

        [Required]
        [Display(Name = "totalVenta")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal totalVenta { get; set; }

    }
}
