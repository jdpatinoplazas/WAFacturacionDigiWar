using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL_FACTURA.Models
{
    [Table("Producto", Schema = "dbo")]
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idProducto { get; set; }

        [Required]
        [Display(Name = "nombreProducto")]
        public string nombreProducto { get; set; }

        [Required]
        [Display(Name = "precioProducto")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal precioProducto { get; set; }

    }
}
