namespace Veterinarios.Models
{
    public class Veterinarios
    {
        public Veterinarios()
        {
            Consultas = new HashSet<Consultas>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string NumCedulaProf { get; set; }

        public string Fotografia { get; set; }

        public ICollection<Consultas> Consultas { get; set; }
    }
}
