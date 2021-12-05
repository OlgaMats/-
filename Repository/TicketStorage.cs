using Art_exhibition.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Art_exhibition.Repository
{
    public class TicketStorage
    {
        private readonly Dictionary<int, Ticket> Tickets = new();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public AuthorStorage() => Connection.Open();

        public void Create(Ticket ticket)
        {
            Tickets.Add(ticket.TicketId, ticket);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Ticket Read(int tickedId)
        {
            return Tickets[tickedId];
        }

        public Ticket Update(int tickedId, Ticket newTicket)
        {
            Tickets[tickedId] = newTicket;
            return Tickets[tickedId];
        }

        public bool Delete(int tickedId)
        {
            return Tickets.Remove(tickedId);
        }
    }
}