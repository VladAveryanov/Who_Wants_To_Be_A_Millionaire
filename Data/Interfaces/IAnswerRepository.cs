using System.Collections.Generic;
using Who_wants_to_be_a_millionaire.Data.Models;

namespace Who_wants_to_be_a_millionaire.Data.Interfaces
{
    public interface IAnswerRepository
    {
        public IEnumerable<Answer> Answers { get; }
    }
}
