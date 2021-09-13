using System.Linq;
using Who_wants_to_be_a_millionaire.Data.Interfaces;
using Who_wants_to_be_a_millionaire.Data.Models;

namespace Who_wants_to_be_a_millionaire.Data.Repository
{
    public class EFQuestionRepository: IQuestionRepository
    {
        private GameDbContext _context;
        public EFQuestionRepository(GameDbContext context)
        {
            _context = context;
        }

        public IQueryable<Question> Questions => _context.Questions;
    }
}
