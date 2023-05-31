using Microsoft.AspNetCore.Identity;

namespace ASP.NET.Core._6.Loja.Filmes.Mvc.Models.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }

    }
}
