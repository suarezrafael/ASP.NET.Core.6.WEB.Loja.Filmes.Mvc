using ASP.NET.Core._6.Loja.Filmes.Mvc.Models.Domain;
using ASP.NET.Core._6.Loja.Filmes.Mvc.Models.DTO;

namespace ASP.NET.Core._6.Loja.Filmes.Mvc.Repositories.Abstract
{
    public interface IMovieService
    {
       bool Add(Movie model);
       bool Update(Movie model);
       Movie GetById(int id);
       bool Delete(int id);
       MovieListVm List(string term = "", bool paging = false, int currentPage = 0);
        List<int> GetGenreByMovieId(int movieId);

    }
}
