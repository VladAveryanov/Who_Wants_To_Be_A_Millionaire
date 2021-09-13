using System.Linq;
using Who_wants_to_be_a_millionaire.Data.Models;

namespace Who_wants_to_be_a_millionaire.Data.Interfaces
{
    public interface IQuestionRepository
    {
        IQueryable<Question> Questions { get; }
    }
}
