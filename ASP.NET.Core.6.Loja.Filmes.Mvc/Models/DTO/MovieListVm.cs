using ASP.NET.Core._6.Loja.Filmes.Mvc.Models.Domain;

namespace ASP.NET.Core._6.Loja.Filmes.Mvc.Models.DTO
{
    public class MovieListVm
    {
        public IQueryable<Movie> MovieList { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public string? Term { get; set; }
    }
}
