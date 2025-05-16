using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademiaTangoApp.Models
{
    public class Clase
    {
        public int Id { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public int EstudianteId { get; set; }

        [ForeignKey("EstudianteId")]
        public Estudiante? Estudiante { get; set; }

        [Required]
        public int ProfesorId { get; set; }

        [ForeignKey("ProfesorId")]
        public Profesor? Profesor { get; set; }
    }
}
