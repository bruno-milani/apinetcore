using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Email é um campo obrigatório para Logar!!!")]
        [EmailAddress(ErrorMessage = "Email no formato inválido!!!")]
        [StringLength(100, ErrorMessage = "Email deve ter no maximo {1} caracteres!!!")]
        public string Email { get; set; }
    }
}
