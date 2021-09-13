using System.Collections.Generic;
using Who_wants_to_be_a_millionaire.Data.Interfaces;
using Who_wants_to_be_a_millionaire.Data.Models;

namespace Who_wants_to_be_a_millionaire.Data.Repository
{
    public class EFAnswerRepository: IAnswerRepository
    {
        private GameDbContext _context;
        public EFAnswerRepository(GameDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Answer> Answers => _context.Answers;
    }
}
