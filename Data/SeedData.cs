using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using Who_wants_to_be_a_millionaire.Data.Models;

namespace Who_wants_to_be_a_millionaire.Data
{
    public class SeedData
    {
        public static void FillDataBase(IApplicationBuilder app)
        {
            GameDbContext context = app.ApplicationServices
            .GetRequiredService<GameDbContext>();

            context.Database.Migrate();
            if (!context.Answers.Any())
            {
                context.Answers.AddRange(
                    new Answer() { QuestionID = 1, AnswerText = "Q_1 A_1", Value = false },
                    new Answer() { QuestionID = 1, AnswerText = "Q_1 A_2", Value = false },
                    new Answer() { QuestionID = 1, AnswerText = "Q_1 A_3", Value = true },
                    new Answer() { QuestionID = 1, AnswerText = "Q_1 A_4", Value = false },

                    new Answer() { QuestionID = 2, AnswerText = "Q_2 A_1", Value = false },
                    new Answer() { QuestionID = 2, AnswerText = "Q_2 A_2", Value = false },
                    new Answer() { QuestionID = 2, AnswerText = "Q_2 A_3", Value = true },
                    new Answer() { QuestionID = 2, AnswerText = "Q_2 A_4", Value = false },

                    new Answer() { QuestionID = 3, AnswerText = "Q_3 A_1", Value = false },
                    new Answer() { QuestionID = 3, AnswerText = "Q_3 A_2", Value = false },
                    new Answer() { QuestionID = 3, AnswerText = "Q_3 A_3", Value = true },
                    new Answer() { QuestionID = 3, AnswerText = "Q_3 A_4", Value = false },

                    new Answer() { QuestionID = 4, AnswerText = "Q_4 A_1", Value = false },
                    new Answer() { QuestionID = 4, AnswerText = "Q_4 A_2", Value = false },
                    new Answer() { QuestionID = 4, AnswerText = "Q_4 A_3", Value = true },
                    new Answer() { QuestionID = 4, AnswerText = "Q_4 A_4", Value = false },

                    new Answer() { QuestionID = 5, AnswerText = "Q_5 A_1", Value = false },
                    new Answer() { QuestionID = 5, AnswerText = "Q_5 A_2", Value = false },
                    new Answer() { QuestionID = 5, AnswerText = "Q_5 A_3", Value = true },
                    new Answer() { QuestionID = 5, AnswerText = "Q_5 A_4", Value = false },

                    new Answer() { QuestionID = 6, AnswerText = "Q_6 A_1", Value = false },
                    new Answer() { QuestionID = 6, AnswerText = "Q_6 A_2", Value = false },
                    new Answer() { QuestionID = 6, AnswerText = "Q_6 A_3", Value = true },
                    new Answer() { QuestionID = 6, AnswerText = "Q_6 A_4", Value = false },

                    new Answer() { QuestionID = 7, AnswerText = "Q_7 A_1", Value = false },
                    new Answer() { QuestionID = 7, AnswerText = "Q_7 A_2", Value = false },
                    new Answer() { QuestionID = 7, AnswerText = "Q_7 A_3", Value = true },
                    new Answer() { QuestionID = 7, AnswerText = "Q_7 A_4", Value = false },

                    new Answer() { QuestionID = 8, AnswerText = "Q_8 A_1", Value = false },
                    new Answer() { QuestionID = 8, AnswerText = "Q_8 A_2", Value = false },
                    new Answer() { QuestionID = 8, AnswerText = "Q_8 A_3", Value = true },
                    new Answer() { QuestionID = 8, AnswerText = "Q_8 A_4", Value = false },

                    new Answer() { QuestionID = 9, AnswerText = "Q_9 A_1", Value = false },
                    new Answer() { QuestionID = 9, AnswerText = "Q_9 A_2", Value = false },
                    new Answer() { QuestionID = 9, AnswerText = "Q_9 A_3", Value = true },
                    new Answer() { QuestionID = 9, AnswerText = "Q_9 A_4", Value = false },

                    new Answer() { QuestionID = 10, AnswerText = "Q_10 A_1", Value = false },
                    new Answer() { QuestionID = 10, AnswerText = "Q_10 A_2", Value = false },
                    new Answer() { QuestionID = 10, AnswerText = "Q_10 A_3", Value = true },
                    new Answer() { QuestionID = 10, AnswerText = "Q_10 A_4", Value = false },

                    new Answer() { QuestionID = 11, AnswerText = "Q_11 A_1", Value = false },
                    new Answer() { QuestionID = 11, AnswerText = "Q_11 A_2", Value = false },
                    new Answer() { QuestionID = 11, AnswerText = "Q_11 A_3", Value = true },
                    new Answer() { QuestionID = 11, AnswerText = "Q_11 A_4", Value = false },

                    new Answer() { QuestionID = 12, AnswerText = "Q_12 A_1", Value = false },
                    new Answer() { QuestionID = 12, AnswerText = "Q_12 A_2", Value = false },
                    new Answer() { QuestionID = 12, AnswerText = "Q_12 A_3", Value = true },
                    new Answer() { QuestionID = 12, AnswerText = "Q_12 A_4", Value = false },

                    new Answer() { QuestionID = 13, AnswerText = "Q_13 A_1", Value = false },
                    new Answer() { QuestionID = 13, AnswerText = "Q_13 A_2", Value = false },
                    new Answer() { QuestionID = 13, AnswerText = "Q_13 A_3", Value = true },
                    new Answer() { QuestionID = 13, AnswerText = "Q_13 A_4", Value = false },

                    new Answer() { QuestionID = 14, AnswerText = "Q_14 A_1", Value = false },
                    new Answer() { QuestionID = 14, AnswerText = "Q_14 A_2", Value = false },
                    new Answer() { QuestionID = 14, AnswerText = "Q_14 A_3", Value = true },
                    new Answer() { QuestionID = 14, AnswerText = "Q_14 A_4", Value = false },

                    new Answer() { QuestionID = 15, AnswerText = "Q_15 A_1", Value = false },
                    new Answer() { QuestionID = 15, AnswerText = "Q_15 A_2", Value = false },
                    new Answer() { QuestionID = 15, AnswerText = "Q_15 A_3", Value = true },
                    new Answer() { QuestionID = 15, AnswerText = "Q_15 A_4", Value = false },

                    new Answer() { QuestionID = 16, AnswerText = "Q_16 A_1", Value = false },
                    new Answer() { QuestionID = 16, AnswerText = "Q_16 A_2", Value = false },
                    new Answer() { QuestionID = 16, AnswerText = "Q_16 A_3", Value = true },
                    new Answer() { QuestionID = 16, AnswerText = "Q_16 A_4", Value = false },

                    new Answer() { QuestionID = 17, AnswerText = "Q_17 A_1", Value = false },
                    new Answer() { QuestionID = 17, AnswerText = "Q_17 A_2", Value = false },
                    new Answer() { QuestionID = 17, AnswerText = "Q_17 A_3", Value = true },
                    new Answer() { QuestionID = 17, AnswerText = "Q_17 A_4", Value = false },

                    new Answer() { QuestionID = 18, AnswerText = "Q_18 A_1", Value = false },
                    new Answer() { QuestionID = 18, AnswerText = "Q_18 A_2", Value = false },
                    new Answer() { QuestionID = 18, AnswerText = "Q_18 A_3", Value = true },
                    new Answer() { QuestionID = 18, AnswerText = "Q_18 A_4", Value = false },

                    new Answer() { QuestionID = 19, AnswerText = "Q_18 A_1", Value = false },
                    new Answer() { QuestionID = 19, AnswerText = "Q_18 A_2", Value = false },
                    new Answer() {  QuestionID = 19, AnswerText = "Q_18 A_3", Value = true },
                    new Answer() {  QuestionID = 19, AnswerText = "Q_18 A_4", Value = false },

                    new Answer() {  QuestionID = 20, AnswerText = "Q_20 A_1", Value = false },
                    new Answer() {  QuestionID = 20, AnswerText = "Q_20 A_2", Value = false },
                    new Answer() {  QuestionID = 20, AnswerText = "Q_20 A_3", Value = true },
                    new Answer() {  QuestionID = 20, AnswerText = "Q_20 A_4", Value = false }
                    );
            }
            if (!context.Questions.Any())
            {
                context.Questions.AddRange(
                    new Question() { QuestionText = "Q1" },
                    new Question() { QuestionText = "Q2" },
                    new Question() { QuestionText = "Q3" },
                    new Question() { QuestionText = "Q4" },
                    new Question() { QuestionText = "Q5" },
                    new Question() { QuestionText = "Q6" },
                    new Question() { QuestionText = "Q7" },
                    new Question() { QuestionText = "Q8" },
                    new Question() { QuestionText = "Q9" },
                    new Question() { QuestionText = "Q10" },
                    new Question() { QuestionText = "Q11" },
                    new Question() { QuestionText = "Q12" },
                    new Question() { QuestionText = "Q13" },
                    new Question() { QuestionText = "Q14" },
                    new Question() { QuestionText = "Q15" },
                    new Question() { QuestionText = "Q16" },
                    new Question() { QuestionText = "Q17" },
                    new Question() { QuestionText = "Q18" },
                    new Question() { QuestionText = "Q19" },
                    new Question() { QuestionText = "Q20" }
                    );
            }
            context.SaveChanges();
        }
    }
}
