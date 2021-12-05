using Art_exhibition.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Art_exhibition.Repository
{
    public class AdminStorage
    {
        private readonly Dictionary<int, Admin> Admins = new();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public void Create(Admin admin)
        {
            Admins.Add(admin.AdminId, admin);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Admin Read(int adminId)
        {
            return Admins[adminId];
        }

        public Admin Update(int adminId, Admin newAdmin)
        {
            Admins[adminId] = newAdmin;
            return Admins[adminId];
        }

        public bool Delete(int adminId)
        {
            return Admins.Remove(adminId);
        }
    }
}