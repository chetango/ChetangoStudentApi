namespace AcademiaTangoApp.Models
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int ClasesPendientes { get; set; }
        public bool PagadoMesActual { get; set; }

        public ICollection<Clase>? Clases { get; set; }
    }
}
