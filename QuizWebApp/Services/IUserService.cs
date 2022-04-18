namespace QuizWebApp.Services
{
    public interface IUserService
    {
        string GetUserID();
        bool IsAuthenticated();
    }
}