using Art_exhibition.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Art_exhibition.Repository
{
    public class VisitorStorage
    {
        private Dictionary<int, Visitor> Visitors { get; } = new Dictionary<int, Visitor>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public void Create(Visitor visitor)
        {
            Visitors.Add(visitor.VisitorId, visitor);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Visitor Read(int visitorId)
        {
            return Visitors[visitorId];
        }

        public Visitor Update(int visitorId, Visitor newVisitor)
        {
            Visitors[visitorId] = newVisitor;
            return Visitors[visitorId];
        }

        public bool Delete(int visitorId)
        {
            return Visitors.Remove(visitorId);
        }
    }
}