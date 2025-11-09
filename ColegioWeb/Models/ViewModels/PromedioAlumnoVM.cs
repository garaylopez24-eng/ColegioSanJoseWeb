namespace ColegioWeb.Models.ViewModels
{
    public class PromedioAlumnoVM
    {
        public int AlumnoId { get; set; }
        public string NombreCompleto { get; set; } = string.Empty;
        public decimal Promedio { get; set; }
    }
}
