using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [Required(ErrorMessage ="O campo E-mail é obrigatório!")]
        [EmailAddress(ErrorMessage ="O campo 'E-mail' é inválido.")]
        public string? Email { get; set; }
        [Required(ErrorMessage ="O campo 'Senha' é obrigatório!")]
        [MinLength(8, ErrorMessage ="O campo 'Senha' tem que ter pelo menos 8 caracteres.")]
        public string? Password { get; set; }
    }
}
