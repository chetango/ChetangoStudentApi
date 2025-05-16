namespace AcademiaTangoApp.Models
{
    public class Profesor
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required string Especialidad { get; set; }

        public ICollection<Clase>? Clases { get; set; }
    }

}
