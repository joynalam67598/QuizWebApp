using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizWebApp.Models;
using QuizWebApp.Repository;
using QuizWebApp.Services;

namespace QuizWebApp.Controllers
{
    [Authorize]
    public class QuizController : Controller
    {
        private readonly IQuizRepository _quizRepository;
        public QuizController(IQuizRepository quizRepository)
        {
            _quizRepository = quizRepository;
        }
        public async  Task<ViewResult> StartTest()
        {
            var questions = await _quizRepository.GetAllQuestion();
            return View(questions);
        }

        public async Task<ViewResult> ShowTestResult(IFormCollection iFormCollection)
        {
            var testResult = await _quizRepository.GetTestResult(iFormCollection);


            return View(testResult);
        }

        public async Task<ViewResult> ShowPreviousTestResult()
        {
            var previousTestResults = await _quizRepository.GetPreviousTestResults();
            return View(previousTestResults);
        }
    }
}
