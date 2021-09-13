using System.Collections.Generic;
using Who_wants_to_be_a_millionaire.Data.Interfaces;
using Who_wants_to_be_a_millionaire.Data.Models;

namespace Who_wants_to_be_a_millionaire.Services
{
    public class DataService: IDataService
    {
        private IQuestionRepository _questionRepository;
        private IAnswerRepository _answerRepository;

        public DataService(IQuestionRepository questionRepository, IAnswerRepository answerRepository)
        {
            _questionRepository = questionRepository;
            _answerRepository = answerRepository;
        }

        public IEnumerable<Answer> Answers => _answerRepository.Answers;
        public IEnumerable<Question> Questions => _questionRepository.Questions;
    }
}
