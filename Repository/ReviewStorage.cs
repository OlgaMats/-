using Art_exhibition.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Art_exhibition.Repository
{
    public class ReviewStorage
    {
        private Dictionary<int, Review> Reviews { get; set; } = new Dictionary<int, Review>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public void Create(Review review)
        {
            Reviews.Add(review.ReviewId, review);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Review Read(int reviewId)
        {
            return Reviews[reviewId];
        }

        public Review Update(int reviewId, Review newAuthor)
        {
            Reviews[reviewId] = newAuthor;
            return Reviews[reviewId];
        }

        public bool Delete(int reviewId)
        {
            return Reviews.Remove(reviewId);
        }
    }
}