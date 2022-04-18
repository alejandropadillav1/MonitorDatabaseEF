using System.ComponentModel.DataAnnotations;

namespace MonitorDatabaseEF.Modelo
{
    public class Estudiante
    {
        [Key]
        public int EstudianteId { get; set; }
        [Required]
        public string Nombres { get; set; }
        [Required]
        public string Apellidos { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string? Caracteristicas { get; set; }
    }
}
