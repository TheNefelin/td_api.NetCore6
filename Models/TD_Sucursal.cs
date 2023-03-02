using System.ComponentModel.DataAnnotations;

namespace td_api.NetCore6.Models
{
    public class TD_Sucursal
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The Text Cannot Exceed the 50 Characters")]
        public string? Nombre { get; set; }
    }
}
