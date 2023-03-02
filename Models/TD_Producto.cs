using System.ComponentModel.DataAnnotations;

namespace td_api.NetCore6.Models
{
    public class TD_Producto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The Text Cannot Exceed the 50 Characters")]
        public string? Nombre { get; set; }

        [Required]
        public int? Precio { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "The Text Cannot Exceed the 500 Characters")]
        public string? Link { get; set; }

        [Required]
        public int? Stock { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "The Text Cannot Exceed the 500 Characters")]
        public string? Etiqueta { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "The Text Cannot Exceed the 500 Characters")]
        public string? Descripcion { get; set; }

        [Required]
        public int? IdCategoria { get; set; }

        [Required]
        public int? IdSucursal { get; set; }
    }
}
