using System;

namespace ColegioWeb.Models
{
    public class Alumno
    {
        public int AlumnoId { get; set; }

        public string Nombres { get; set; } = string.Empty;

        public string Apellidos { get; set; } = string.Empty;

        public DateTime? FechaNacimiento { get; set; }

        public string Correo { get; set; } = string.Empty;

        // Relación: un alumno puede tener muchos expedientes
        public ICollection<Expediente>? Expedientes { get; set; }
    }
}
