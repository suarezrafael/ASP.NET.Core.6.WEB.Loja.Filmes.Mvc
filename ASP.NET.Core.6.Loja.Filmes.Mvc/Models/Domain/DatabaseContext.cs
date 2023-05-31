using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET.Core._6.Loja.Filmes.Mvc.Models.Domain
{
    public class DatabaseContext : IdentityDbContext<ApplicationUser>
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
    }
}
