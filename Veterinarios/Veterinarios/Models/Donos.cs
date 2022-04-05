using System.ComponentModel.DataAnnotations;

namespace Vets.Models
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
        [StringLength(20, ErrorMessage = "O {0} nao pode ter mais que {1} caracteres")]
        [RegularExpression("[A-ZÂÓÍa-zçáéíóúãàèìòùâêîôûõëäïöüñ '-]+",ErrorMessage ="No {0} só são aceites letras")]
        public string Name { get; set; }

        /// <summary>
        /// NIF do dono do animal
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatorio")]
        [StringLength(9,MinimumLength =9, ErrorMessage ="O {0} tem que ter {1} caracteres")]
        [RegularExpression("[123578]+[0-9]{8}",ErrorMessage ="O{0} deve começar por 1,2,3,5,7ou 8 e so ter algarismos")]
        public string Nif { get; set; }

        /// <summary>
        /// Sexo do dono
        /// Ff - fem ; Mm - masc
        /// </summary>
        [RegularExpression("[FfmM]", ErrorMessage ="No {0} só se aceita as letras F ou M")]
        [StringLength(1, ErrorMessage = "O {0} nao pode ter mais que {1} caracter")]
        public string Sexo { get; set; }

        /// <summary>
        /// Contacto email do dono do animal 
        /// </summary>
        [EmailAddress(ErrorMessage ="Introduza um email correcto")]
        public string Email { get; set; }

        public ICollection<Animais> Animais { get; set; }
    }
}
