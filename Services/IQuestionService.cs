using System.Collections.Generic;
using Who_wants_to_be_a_millionaire.Data.Models;

namespace Who_wants_to_be_a_millionaire.Services
{
    public interface IQuestionService
    {
        public List<Question> SetCount(int count);
        public List<Question> GetQuestions();
        public List<Question> ShuffleQuestions(List<Question> questions);
        public List<Answer> GetAnswers();
    }
}
