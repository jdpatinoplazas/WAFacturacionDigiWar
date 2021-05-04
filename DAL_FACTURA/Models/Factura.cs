using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL_FACTURA.Models
{
    [Table("Factura", Schema = "dbo")]
    public class Factura
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idFactura { get; set; }

        [Required]
        [Display(Name = "idProducto")]
        public int idProducto { get; set; }

        [Required]
        [Display(Name = "fechaProducto")]
        public DateTime fechaProducto { get; set; }

        [Required]
        [Display(Name = "idVenta")]
        public int idVenta { get; set; }

        [Required]
        [Display(Name = "cantidadProducto")]
        public int cantidadProducto { get; set; }

        [Required]
        [Display(Name = "precioProducto")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal precioProducto { get; set; }

    }
}
