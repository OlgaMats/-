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
    [Route("/requisite")]
    public class RequisiteController : ControllerBase
    {
        [HttpPut]
        public Requisite Create(Requisite requisite)
        {
            Storage.RequisiteStorage.Create(requisite);
            return requisite;// Метод создания
        }

        [HttpGet]
        public Requisite Read(int requisiteId)
        {
            return Storage.RequisiteStorage.Read(requisiteId);// Метод чтения
        }

        [HttpPatch]
        public Requisite Update(int requisiteId, Requisite newRequisite)
        {
            return Storage.RequisiteStorage.Update(requisiteId, newRequisite);
        }

        [HttpDelete]
        public bool Delete(int requisiteId)
        {
            return Storage.RequisiteStorage.Delete(requisiteId);
        }
    }
}