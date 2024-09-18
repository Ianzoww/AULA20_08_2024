using System.ComponentModel.DataAnnotations;
using static aula20_08_2024.Validations.ValidarMaioridade;
using static aula20_08_2024.Uteis.ValidadorCPF;
using aula20_08_2024.Uteis;
using aula20_08_2024.Validations;

namespace aula20_08_2024.Modells
{
    public class Aluno
    {

        [Required(ErrorMessage = "Obrigatório")]
        [MaxLength(10, ErrorMessage = "Maximo 10 letras ")]
        public string? Nome { get; set; }


        [Required(ErrorMessage = "Obrigatório")]
        [EmailAddress(ErrorMessage = "Email invalido")]
        public string? Email { get; set; }


        [Required(ErrorMessage = "Obrigatório")]
        public string? Telefone { get; set; }


        [Required(ErrorMessage = "Obrigatório")]
        [ValidarCPF(ErrorMessage = "CPF Invalido")] 
        public string? CPF { get; set; }


        [MaioridadeValidation(ErrorMessage = "Erro idade")]
        public int Idade { get; set; }
    }
}
