using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using QuizWebApp.Data;
using QuizWebApp.Models;
using QuizWebApp.Services;

namespace QuizWebApp.Repository
{
    public class QuizRepository : IQuizRepository
    {
        private readonly QuizContext _quizContext;

        private readonly IUserService _userService;
        public QuizRepository(QuizContext quizContext, IUserService userService)
        {
            _quizContext = quizContext;
            _userService = userService;
        }

        public async Task<List<QuizModel>> GetAllQuestion()
        {
            return await _quizContext.Quizs.Select(quiz => new QuizModel()
            {
                Id = quiz.Id,
                Question = quiz.Question,
                OptionA = quiz.OptionA,
                OptionB = quiz.OptionB,
                OptionC = quiz.OptionC,
                OptionD = quiz.OptionD,
                CorrectAnswer = quiz.CorrectAnswer

            }).ToListAsync();
        }

        public async Task<Tests> GetTestResult(IFormCollection iFormCollection)
        {
            var questionIds = iFormCollection["questionId"];
            var correct = 0;

            foreach (var id in questionIds)
            {
                var selectedValue = iFormCollection["question_" + id];
                if (string.IsNullOrEmpty(selectedValue)) selectedValue = "#";
                var question = await _quizContext.Quizs.FindAsync(int.Parse(id));
                if (selectedValue == question.CorrectAnswer) correct += 1;
            }

            var wrong = 20 - correct;
            var userId = _userService.GetUserID();
            var newTestResult = new Tests()
            {
                Correct = correct,
                Wrong = wrong,
                TotalQuestion = 20,
                Score = correct,
                UserId = userId,
                QuizDate = DateTime.UtcNow,
            };
            _quizContext.Add(newTestResult);
            await _quizContext.SaveChangesAsync();
            return newTestResult;
        }

        public async Task<List<TestModel>> GetPreviousTestResults()
        {
            var userId = _userService.GetUserID();

            return await _quizContext.Tests.Where(test => test.UserId == userId).
                Select(test => new TestModel()
            {
                Score = test.Score,
                TotalQuestion = test.TotalQuestion,
                Correct = test.Correct,
                Wrong = test.Wrong,
                QuizDate = test.QuizDate,

            }).ToListAsync();
        }
    }
}
