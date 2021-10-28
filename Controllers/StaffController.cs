using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Art_exhibition.Controllers
{
    [ApiController]
    [Route("/staff")]
    public class StaffController : ControllerBase
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

        [HttpGet("EditInformation")]
        public string EditInformation(string str)
        {
            return str;// "Метод редактирования информации об экспонатах"
        }

        [HttpGet("CheckSafety")]
        public string CheckSafety(string str)
        {
            return str;// "Метод проверки экспонатов на сохранность"
        }

        [HttpGet("RegNewExhibits")]
        public string RegNewExhibits(string str)
        {
            return str;// "Метод регистрации новых экспонатов"
        }
    }
}