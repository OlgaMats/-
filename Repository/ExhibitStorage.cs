using Art_exhibition.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Art_exhibition.Repository
{
    public class ExhibitStorage
    {
        private Dictionary<int, Exhibit> Exhibits { get; } = new Dictionary<int, Exhibit>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public void Create(Exhibit exhibit)
        {
            Exhibits.Add(exhibit.ExhibitId, exhibit);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Exhibit Read(int exhibitId)
        {
            return Exhibits[exhibitId];
        }

        public Exhibit Update(int exhibitId, Exhibit newExhibit)
        {
            Exhibits[exhibitId] = newExhibit;
            return Exhibits[exhibitId];
        }

        public bool Delete(int exhibitId)
        {
            return Exhibits.Remove(exhibitId);
        }
    }
}