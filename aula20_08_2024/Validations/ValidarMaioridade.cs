using System.ComponentModel.DataAnnotations; // Importa o namespace necessário para usar os atributos de validação.

namespace aula20_08_2024.Validations
{
    public class ValidarMaioridade
    {
        // Classe interna que herda de ValidationAttribute para criar a validação personalizada.
        public class MaioridadeValidation : ValidationAttribute
        {
            // Sobrescrita do metodo herdado
            // A variavel value do tipo objet é o valor avaliado(idade)
            public override bool IsValid(Object? value)
            {
                if (value == null)
                {
                    return false;
                }
                int idade = (int)value;

                return idade >= 18;
            }
        }
    }
}
