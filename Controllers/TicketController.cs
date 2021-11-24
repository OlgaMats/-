using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Art_exhibition.Domain;
using Art_exhibition.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Art_exhibition.Controllers
{
    [ApiController]
    [Route("/ticket")]
    public class TicketController : ControllerBase
    {
        [HttpPut]
        public Ticket Create(Ticket ticket)
        {
            Storage.TicketStorage.Create(ticket);
            return ticket;// Метод создания
        }

        [HttpGet]
        public Ticket Read(int ticketId)
        {
            return Storage.TicketStorage.Read(ticketId);// Метод чтения
        }

        [HttpPatch]
        public Ticket Update(int ticketId, Ticket newTicket)
        {
            return Storage.TicketStorage.Update(ticketId, newTicket);
        }

        [HttpDelete]
        public bool Delete(int ticketId)
        {
            return Storage.TicketStorage.Delete(ticketId);
        }
    }
}