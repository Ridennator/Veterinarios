using System.ComponentModel.DataAnnotations;

namespace Veterinarios.Models
{
    /// <summary>
    /// Representa os dados do Dono de um animal
    /// </summary>
    public class Donos
    {

        public Donos()
        {
            Animais = new HashSet<Animais>(); 
        }
        /// <summary>
        /// PK pata a tabela dos DOnos
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Nome do Dono do animal
        /// </summary>
        [Required(ErrorMessage ="O {0} é de preenchimento obrigatorio")]
        public string Name { get; set; }

        /// <summary>
        /// NIF do dono do animal
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatorio")]
        public string Nif { get; set; }

        /// <summary>
        /// Sexo do dono
        /// Ff - fem ; Mm - masc
        /// </summary>
        public string Sexo { get; set; }

        public ICollection<Animais> Animais { get; set; }
    }
}
