using Art_exhibition.Domain;
using System.Collections.Generic;
using System.Linq;


namespace Art_exhibition.Repository
{
    public class AuthorStorage
    {
<<<<<<< HEAD
        private readonly Dictionary<int, Author > Authors = new ();
        private SqlConnection Connection { get; } = new SqlConnection(@"Server=DESKTOP-9FJOISL\SQLEXPRESS;Database=Art-Exhibition;User Id=sa;Password=123;");
        public AuthorStorage() => Connection.Open();
=======
        private readonly Dictionary<int, Author> Authors = new();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

>>>>>>> 44c33e8134958d3e865c7fa202bd865c3d555318
        public Author Create(Author author)
        {
            // var connectionId = _connections.Keys.Last() + 1;
            var authorId = Authors.Keys.Max() + 1;
            author.AuthorId = authorId;
            Authors.Add(author.AuthorId, author);
            return author;
            //var command = Connection.CreateCommand();
<<<<<<< HEAD
            //command.CommandText = "SELECT * FROM dbo.Author WHERE authorId = @AuthorId";
            //command.ExecuteNonQuery();
            //command.ExecuteReader();
            //command.ExecuteScalar();
=======
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
>>>>>>> 44c33e8134958d3e865c7fa202bd865c3d555318
        }

        public Author Read(int authorId)
        {
<<<<<<< HEAD
            var command = Connection.CreateCommand();
            command.CommandText = "SELECT * FROM dbo.Author WHERE authorId = @AuthorId";
=======
>>>>>>> 44c33e8134958d3e865c7fa202bd865c3d555318
            return Authors[authorId];
        }

        public Author Update(int authorId, Author newAuthor)
        {
            Authors[authorId] = newAuthor;
            return Authors[authorId];
        }

        public bool Delete(int authorId)
        {
            return Authors.Remove(authorId);
        }
    }
}