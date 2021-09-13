using System.Collections.Generic;
using Who_wants_to_be_a_millionaire.Data.Models;

namespace Who_wants_to_be_a_millionaire.Data.ViewModels
{
    public class GameSession
    {
        public int ID;
        public List<Answer> _answers;
        public List<Question> _questions;
        public int CurrentQuestionID;

        public bool Fifty_Fifty = true;
        public int CurrentScore { get; set; }
        public int PrizeStep { get; }

        public GameSession(int id, List<Answer> answers, List<Question> questions, int count)
        {
            ID = id;
            _answers = answers;
            _questions = questions;
            CurrentQuestionID = 0;
            PrizeStep = 1_005_000 / count;
        }

       
    }
}
