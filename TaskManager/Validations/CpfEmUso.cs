using System.ComponentModel.DataAnnotations;

using API.models;


namespace Api_Usuario.Validations
{
    public class CpfEmUso : ValidationAttribute
    {
        // public CpfEmUso(string cpf) { }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string cpf = (string)value;

            DataContext context =
                (DataContext)validationContext.GetService(typeof(DataContext));

            Usuario usuario = context.Usuarios.FirstOrDefault
                (f => f.Cpf.Equals(cpf));
                
            if (usuario == null)
            {
                //Caso de sucesso
                return ValidationResult.Success;
            }
            //Caso de erro
            return new ValidationResult("O CPF do funcionário já está em uso!");
        }
    }
}