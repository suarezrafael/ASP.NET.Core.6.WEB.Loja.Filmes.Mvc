using ASP.NET.Core._6.Loja.Filmes.Mvc.Models.DTO;

namespace ASP.NET.Core._6.Loja.Filmes.Mvc.Repositories.Abstract
{
    public interface IUserAuthenticationService
    {

        Task<Status> LoginAsync(LoginModel model);
        Task LogoutAsync();
        Task<Status> RegisterAsync(RegistrationModel model);
        //Task<Status> ChangePasswordAsync(ChangePasswordModel model, string username);
    }
}
