using System;
using System.Collections.Generic;
using System.Linq;
using Who_wants_to_be_a_millionaire.Data.Models;


namespace Who_wants_to_be_a_millionaire.Services
{

    public class QuestionService: IQuestionService
    {
        private IDataService _dataService;
        
        public QuestionService(IDataService dataService)
        {
            _dataService = dataService;
        }

        public List<Answer> GetAnswers()
        {
            var answerList = _dataService.Answers.ToList();
            return ShuffleAnswers(answerList); 
        }

        public List<Question> GetQuestions()
        {
            var questionsList = _dataService.Questions.ToList();
            return questionsList;
        } 

        public List<Question> ShuffleQuestions(List<Question> questions)
        {
            Random rnd = new Random();
            var list = questions.OrderBy(x => rnd.Next()).ToList();
            return list;
        }

        public List<Answer> ShuffleAnswers(List<Answer> answers)
        {
            var rnd = new Random();
            var list = answers.OrderBy(x => rnd.Next()).ToList();
            return list;
        }

        public List<Question> SetCount(int count)
        {
            var list = GetQuestions();
            var shuffledList = ShuffleQuestions(list);

            var qList = new List<Question>(count);
            for (int i = 0; i < count; i++)
            {
                qList.Add(shuffledList[i]);
            }
            return qList;
        }
    }
}
