using System.Collections.Generic;
using Who_wants_to_be_a_millionaire.Data.Models;

namespace Who_wants_to_be_a_millionaire.Services
{
    public interface IDataService
    {
        public IEnumerable<Question> Questions { get; }
        public IEnumerable<Answer> Answers { get; }
    }
}
