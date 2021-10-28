using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Art_exhibition.Controllers
{
    [ApiController]
    [Route("/requisite")]
    public class RequisiteController : ControllerBase
    {
        [HttpPut]
        public string Create(string str)
        {
            return str;// Метод создания
        }

        [HttpGet]
        public string Read(string str)
        {
            return str;// Метод чтения
        }

        [HttpPatch]
        public string Update(string str)
        {
            return str;// Метод обновления
        }

        [HttpDelete]
        public string Delete(string str)
        {
            return str;// Метод удаления
        }
    }
}