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
    [Route("/exhibit")]
    public class ExhibitController : ControllerBase
    {
        [HttpPut]
        public Exhibit Create(Exhibit exhibit)
        {
            Storage.ExhibitStorage.Create(exhibit);
            return exhibit;// Метод создания
        }

        [HttpGet]
        public Exhibit Read(int exhibitId)
        {
            return Storage.ExhibitStorage.Read(exhibitId);// Метод чтения
        }

        [HttpPatch]
        public Exhibit Update(int exhibitId, Exhibit newExhibit)
        {
            return Storage.ExhibitStorage.Update(exhibitId, newExhibit);
        }

        [HttpDelete]
        public bool Delete(int exhibitId)
        {
            return Storage.ExhibitStorage.Delete(exhibitId);
        }
    }
}