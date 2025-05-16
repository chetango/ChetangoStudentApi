using System.ComponentModel.DataAnnotations;

namespace AcademiaTangoApp.Models
{
    public class Profesor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La especialidad es obligatoria.")]
        [StringLength(50)]
        public string Especialidad { get; set; }

        public ICollection<Clase>? Clases { get; set; }
    }
}
