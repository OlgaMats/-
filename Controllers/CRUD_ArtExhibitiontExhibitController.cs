using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Art_exhibition.Controllers
{
    [ApiController]
    [Route("/exhibit")]
    public class ExhibitController : ControllerBase
    {
        [HttpPut("Create")]
        public string Create(string str)
        {
            return str;// Метод создания
        }

        [HttpGet("Read")]
        public string Read(string str)
        {
            return str;// Метод чтения
        }

        [HttpPatch("Update")]
        public string Update(string str)
        {
            return str;// Метод обновления
        }

        [HttpDelete("Delete")]
        public string Delete(string str)
        {
            return str;// Метод удаления
        }
    }
}