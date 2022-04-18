using System;
using System.ComponentModel.DataAnnotations;

namespace QuizWebApp.Data
{
    public class Tests
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public int TotalQuestion { get; set; }
        public int Score { get; set; }

        public int Correct { get; set; }
        public int Wrong { get; set; }

        [DataType(DataType.Date)]
        public DateTime QuizDate { get; set; }
    }
}
