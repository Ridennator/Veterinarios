using System.ComponentModel.DataAnnotations.Schema;

namespace Veterinarios.Models
{
    public class Animais
    {
        public Animais()
        {
            ListaConsultas = new HashSet<Consultas>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Raca { get; set; }

        public int Especie { get; set; }
        
        public DateTime DataNascimento { get; set; }

        public float Peso { get; set; }

        public string Fotografia { get; set; }

        [ForeignKey(nameof(Dono))]
        public int DonoFK { get; set; }

        public Donos Dono { get; set; }
        public ICollection<Consultas> ListaConsultas { get; set; }
    }
}
