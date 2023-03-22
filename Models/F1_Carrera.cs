using System.ComponentModel.DataAnnotations;

namespace td_api.NetCore6.Models
{
    public class F1_Carrera
    {
        public int IdCircuito { get; set; }
        public int IdPiloto { get; set; }
        public int Distancia { get; set; }
        public int Puntaje { get; set; }
        public int Lugar { get; set; }
        public bool CarreraTerminada { get; set; }
        public bool Incidente { get; set; }
        [StringLength(255, ErrorMessage = "The Text Cannot Exceed the 255 Characters")]
        public string? Motivo { get; set; }
    }
}
