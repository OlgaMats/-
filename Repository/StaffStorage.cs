using Art_exhibition.Domain;
using System.Collections.Generic;

namespace Art_exhibition.Repository
{
    public class StaffStorage
    {
        private readonly Dictionary<int, Staff> Staffs = new();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public void Create(Staff staff)
        {
            Staffs.Add(staff.StaffId, staff);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Staff Read(int staffId)
        {
            return Staffs[staffId];
        }

        public Staff Update(int staffId, Staff newStaff)
        {
            Staffs[staffId] = newStaff;
            return Staffs[staffId];
        }

        public bool Delete(int staffId)
        {
            return Staffs.Remove(staffId);
        }
    }
}