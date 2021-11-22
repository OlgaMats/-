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
    [Route("/visitor")]
    public class VisitorController : ControllerBase
    {
        [HttpPut]
        public Visitor Create(Visitor visitor)
        {
            Storage.VisitorStorage.Create(visitor);
            return visitor;
        }

        [HttpGet]
        public Visitor Read(int visitorId)
        {
            return Storage.VisitorStorage.Read(visitorId);// Метод чтения
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

        [HttpGet("ViewingExhibits")]
        public string ViewingExhibits(string str)
        {
            return str;//"Метод выбора экспонатов для просмотра"
        }

        [HttpGet("Registration")]
        public string Registration(string str)
        {
            return str;//"Метод регистрации посетителя"
        }

        [HttpGet("Login")]
        public string Login(string str)
        {
            return str;//"Метод рвхода в личный кабинет посетителя"
        }

        [HttpGet("Review")]
        public string Review(string str)
        {
            return str;//"Метод оценки выставки"
        }

        [HttpGet("Question")]
        public string Question(string str)
        {
            return str;//"Метод ооставления вопроса"
        }


        [HttpGet("Information")]
        public string Information(string str)
        {
            return str;// "Метод ознакомления со сведениями о выставке"
        }

        [HttpGet("InfoAdressTimetable")]
        public string AdressTimetable(string str)
        {
            return str;//"Метод ознакомления с адресом и расписанием"
        }

        [HttpGet("InfoPrices")]
        public string InfoPrices(string str)
        {
            return str;//"Метод ознакомления с ценой билетов"
        }
    }
}