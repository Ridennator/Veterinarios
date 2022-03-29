using System.ComponentModel.DataAnnotations.Schema;

namespace Veterinarios.Models
{
    public class Consultas
    {
        public int Id { get; set; }

        public DateTime Data { get; set; }

        public string Observacoes { get; set; }

        public decimal ValorConsulta { get; set; }

        [ForeignKey(nameof(Animal))]
        public int AnimalFK { get; set; }
        public Animais Animal { get; set; }

        [ForeignKey(nameof(Veterinarios))]
        public int VeterinariosFK { get; set; }
        public Veterinarios Veterinarios { get; set; }
    }
}
