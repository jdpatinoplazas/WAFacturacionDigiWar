using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL_FACTURA.Models
{
    [Table("Inventario", Schema = "dbo")]
    public class Inventario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idInventario { get; set; }

        [Required]
        [Display(Name = "idProducto")]
        public int idProducto { get; set; }

        [Required]
        [Display(Name = "existenciaInventario")]
        public int existenciaInventario { get; set; }

    }
}
