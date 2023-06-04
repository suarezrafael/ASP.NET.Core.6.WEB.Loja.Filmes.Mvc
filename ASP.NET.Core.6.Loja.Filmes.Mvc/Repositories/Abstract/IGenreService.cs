using ASP.NET.Core._6.Loja.Filmes.Mvc.Models.Domain;
using ASP.NET.Core._6.Loja.Filmes.Mvc.Models.DTO;

namespace ASP.NET.Core._6.Loja.Filmes.Mvc.Repositories.Abstract
{
    public interface IGenreService
    {
       bool Add(Genre model);
       bool Update(Genre model);
       Genre GetById(int id);
       bool Delete(int id);
       IQueryable<Genre> List();

    }
}
