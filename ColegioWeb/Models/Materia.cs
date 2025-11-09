namespace ColegioWeb.Models
{
    public class Materia
    {
        public int MateriaId { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Descripcion { get; set; }
        public ICollection<Expediente>? Expedientes { get; set; }
    }
}

