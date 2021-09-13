using System;
using System.Collections.Generic;
using Who_wants_to_be_a_millionaire.Data.Models;
using Who_wants_to_be_a_millionaire.Data.ViewModels;

namespace Who_wants_to_be_a_millionaire.Services
{
    public class GameService: IGameService
    {
        private Dictionary<int, GameSession> sessions;
        private IQuestionService _questionService;

        public GameService(IQuestionService questionService)
        {
            sessions = new Dictionary<int, GameSession>();
            _questionService = questionService;
        }

        public GameSession GetGameSession(int gsID)
        {
            return sessions[gsID];
        }
        public GameSession InitGameSession(int count)
        {
            int ID = new Random().Next();
            var gameSession = new GameSession(ID, _questionService.GetAnswers(), _questionService.SetCount(count), count);
            sessions.Add(ID, gameSession);
            return gameSession;
        }

        public Question CurrentQuestion(int sessionID)
        {
            var session = sessions[sessionID];
            return session._questions[session.CurrentQuestionID];
        }

        public GameSession Fifty_Fifty(int sessionID)
        {
            var currentSession = GetGameSession(sessionID);
            var answers = currentSession._answers;
            var rnd = new Random();
            int rightAnswer = 0;
            int wrongAnswer_1_ID;
            int wrongAnswer_2_ID;

            var ans = new List<int>();
            foreach (var e in answers)
            {
                if (e.QuestionID == currentSession._questions[currentSession.CurrentQuestionID].ID)
                {
                    ans.Add(e.ID);
                    if(e.Value)
                        rightAnswer = e.ID;
                }   
            }

            wrongAnswer_1_ID = rnd.Next(0,3);
            while (rightAnswer == ans[wrongAnswer_1_ID])
                wrongAnswer_1_ID = rnd.Next(0,3);

            wrongAnswer_2_ID = rnd.Next(0, 3);
            while (rightAnswer == ans[wrongAnswer_2_ID] || ans[wrongAnswer_1_ID] == ans[wrongAnswer_2_ID])
                wrongAnswer_2_ID = rnd.Next(0, 3);

            var list = new List<Answer>();
            foreach (var e in answers)
            {
                if (e.ID != ans[wrongAnswer_2_ID] && e.ID != ans[wrongAnswer_1_ID])
                    list.Add(e);
            }
            currentSession._answers = list;
            return currentSession;
        }

        public bool ChekAnswer(int answerID, GameSession gameSession)
        {
            foreach (var e in gameSession._answers)
            {
                if (e.ID == answerID)
                    return e.Value;
            }
            return true;
        }
    }
}
