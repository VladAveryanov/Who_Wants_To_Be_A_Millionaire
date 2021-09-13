using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Who_wants_to_be_a_millionaire.Data.ViewModels;
using Who_wants_to_be_a_millionaire.Models;
using Who_wants_to_be_a_millionaire.Services;

namespace Who_wants_to_be_a_millionaire.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IQuestionService _questionService;
        private IGameService _gameService;

        public HomeController(ILogger<HomeController> logger, IQuestionService service, IGameService gameService)
        {
            _logger = logger;
            _questionService = service;
            _gameService = gameService;
        }

        public IActionResult Index()
        {
            return View("StartPage");
        }

        [HttpPost]
        public IActionResult GetAnswer(int answerID, int gameSessionID)
        {
            var gameSession = _gameService.GetGameSession(gameSessionID);

            if (_gameService.ChekAnswer(answerID, gameSession))
            {
                gameSession.CurrentQuestionID++;
                gameSession.CurrentScore += gameSession.PrizeStep;
                if (gameSession.CurrentQuestionID < gameSession._questions.Count)
                {
                    return View("QuestionPage", gameSession);
                }
                else return View("Win", gameSession.CurrentScore);
            }
            else return View("GameOver");  
        }

        [HttpPost]
        public IActionResult InitGame(int count)
        {
            GameSession gs = _gameService.InitGameSession(count);
            return View("QuestionPage", gs);
        }

        [HttpPost]
        public IActionResult Fifty_Fifty(int gameSessionID)
        {
            var gameSession = _gameService.GetGameSession(gameSessionID);
            gameSession.Fifty_Fifty = false;
            return View("QuestionPage", _gameService.Fifty_Fifty(gameSessionID));
        }

        [HttpPost]
        public IActionResult End()
        {
            return View("End");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
