using System.ComponentModel.DataAnnotations;

namespace ASP.NET.Core._6.Loja.Filmes.Mvc.Models.Domain
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        public string? GenreName { get; set; }
    }
}
