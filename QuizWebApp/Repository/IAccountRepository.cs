using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using QuizWebApp.Models;

namespace QuizWebApp.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> CreateUserAsync(SignUpModel userModel);
        Task<SignInResult> PasswordSignInAsync(SignInModel signInModel);
        Task SignOutAsync();
    }
}