namespace AcademiaTangoApp.Models
{
    public class Clase
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        public int EstudianteId { get; set; }
        public Estudiante? Estudiante { get; set; }

        public int ProfesorId { get; set; }
        public Profesor? Profesor { get; set; }
    }
}
