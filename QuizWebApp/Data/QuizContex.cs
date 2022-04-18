using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuizWebApp.Models;

namespace QuizWebApp.Data
{
    public class QuizContext : IdentityDbContext<ApplicationUser>
    {
        public QuizContext(DbContextOptions<QuizContext> options) : base(options)
        {

        }

        public DbSet<Quizs> Quizs { get; set; }

        public DbSet<Tests> Tests { get; set; }


    }
}
