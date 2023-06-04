using System.ComponentModel.DataAnnotations;

namespace ASP.NET.Core._6.Loja.Filmes.Mvc.Models.Domain
{
    public class MovieGenre
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int GenreId { get; set; }
    }
}
