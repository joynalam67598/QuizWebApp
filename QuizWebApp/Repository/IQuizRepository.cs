using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using QuizWebApp.Data;
using QuizWebApp.Models;

namespace QuizWebApp.Repository
{
    public interface IQuizRepository
    {
        Task<List<QuizModel>> GetAllQuestion();
        Task<Tests> GetTestResult(IFormCollection iFormCollection);
        Task<List<TestModel>> GetPreviousTestResults();

    }
}