using System.ComponentModel.DataAnnotations;

namespace AcademiaTangoApp.Models
{
    public class Estudiante
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede superar los 100 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El email es obligatorio.")]
        [EmailAddress(ErrorMessage = "El email no tiene un formato válido.")]
        public string Email { get; set; }

        [Required]
        public DateTime FechaRegistro { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Las clases pendientes no pueden ser negativas.")]
        public int ClasesPendientes { get; set; }

        public bool PagadoMesActual { get; set; }

        public ICollection<Clase>? Clases { get; set; }
    }
}
