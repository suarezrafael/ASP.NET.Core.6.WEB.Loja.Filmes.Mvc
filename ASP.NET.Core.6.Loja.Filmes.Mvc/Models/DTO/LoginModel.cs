using System.ComponentModel.DataAnnotations;

namespace ASP.NET.Core._6.Loja.Filmes.Mvc.Models.DTO
{
    public class LoginModel
    {
        [Required]
        public string? Username { get; set; }

        [Required]
        public string? Password { get; set; }
       
    }
}
