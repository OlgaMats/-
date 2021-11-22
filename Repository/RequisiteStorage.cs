using Art_exhibition.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Art_exhibition.Repository
{
    public class RequisiteStorage
    {
        private Dictionary<int, Requisite> Requisites { get; set; } = new Dictionary<int, Requisite>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public void Create(Requisite requisite)
        {
            Requisites.Add(requisite.RequisiteId, requisite);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Requisite Read(int requisiteId)
        {
            return Requisites[requisiteId];
        }

        public Requisite Update(int requisiteId, Requisite newRequisite)
        {
            Requisites[requisiteId] = newRequisite;
            return Requisites[requisiteId];
        }

        public bool Delete(int requisiteId)
        {
            return Requisites.Remove(requisiteId);
        }
    }
}