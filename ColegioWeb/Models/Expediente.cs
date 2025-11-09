namespace ColegioWeb.Models
{
    public class Expediente
    {
        public int ExpedienteId { get; set; }

        public int AlumnoId { get; set; }

        public int MateriaId { get; set; }

        public decimal NotaFinal { get; set; }

        public string? Observaciones { get; set; }

        // Propiedades de navegación (para .Include y para las vistas)
        public Alumno? Alumno { get; set; }

        public Materia? Materia { get; set; }
    }
}
