namespace SistemaGestionEscolar.Models
{
    public class Aula
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public int Capacidad { get; set; }

        public string Ubicacion { get; set; } = string.Empty;

        public string Estado { get; set; } = string.Empty;
    }
}