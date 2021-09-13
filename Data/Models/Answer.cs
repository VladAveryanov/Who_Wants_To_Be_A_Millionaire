
namespace Who_wants_to_be_a_millionaire.Data.Models
{
    public class Answer
    {
        public int ID { get; set; }
        public string AnswerText { get; set; }
        public bool Value { get; set; }
        public int QuestionID { get; set; }
    }
}
