using aula20_08_2024.Uteis;
using System.ComponentModel.DataAnnotations;

namespace aula20_08_2024.Validations
{
    public class ValidarCPF : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            return ValidadorCPF.VerificaCPF(value.ToString());
 
        }
    }
}
