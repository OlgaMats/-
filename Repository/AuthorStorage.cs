using Art_exhibition.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;


namespace Art_exhibition.Repository
{
    public class AuthorStorage
    {
        private readonly Dictionary<int, Author > Authors = new ();
        private SqlConnection Connection { get; } = new SqlConnection(@"Server=DESKTOP-9FJOISL\SQLEXPRESS;Database=Art-Exhibition;User Id=sa;Password=123;");
        public AuthorStorage() => Connection.Open();
        public Author Create(Author author)
        {
            //var authorId = Authors.Keys.Max() + 1;
            //author.AuthorId= authorId;
            Authors.Add(author.AuthorId, author);
            return author;
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM dbo.Author WHERE authorId = @AuthorId";
            //command.ExecuteNonQuery();
            //command.ExecuteReader();
            //command.ExecuteScalar();
        }

        public Author Read(int authorId)
        {
            var command = Connection.CreateCommand();
            command.CommandText = "SELECT * FROM dbo.Author WHERE authorId = @AuthorId";
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