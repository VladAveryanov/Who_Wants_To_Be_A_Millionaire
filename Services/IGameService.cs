using Who_wants_to_be_a_millionaire.Data.Models;
using Who_wants_to_be_a_millionaire.Data.ViewModels;

namespace Who_wants_to_be_a_millionaire.Services
{
    public interface IGameService
    {
        public Question CurrentQuestion(int sessionID);
        public GameSession InitGameSession(int count);
        public GameSession GetGameSession(int gsID);
        public bool ChekAnswer(int answerID, GameSession gameSession);
        public GameSession Fifty_Fifty(int sessionID);



    }
}
