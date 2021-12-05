using Art_exhibition.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Art_exhibition.Repository
{
    public class QuestionStorage
    {
        private readonly Dictionary<int, Question> Questions = new();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public void Create(Question question)
        {
            Questions.Add(question.QuestionId, question);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Question Read(int questionId)
        {
            return Questions[questionId];
        }

        public Question Update(int questionId, Question newQuestion)
        {
            Questions[questionId] = newQuestion;
            return Questions[questionId];
        }

        public bool Delete(int questionId)
        {
            return Questions.Remove(questionId);
        }
    }
}