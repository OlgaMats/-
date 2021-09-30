using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Art_exhibition.Controllers
{
    [ApiController]
    [Route("/client")]
    public class ClientController : ControllerBase
    {
        [HttpGet("ViewingExhibits")]
        public string ViewingExhibits(string str)
        {
            return str;//"Метод выбора просмотра экспонатов"
        }

        [HttpGet("Review")]
        public string Review(string str)
        {
            return str;//"Метод оценки выставки"
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
            return str;//"Метод ознакомления с адресом и расписанием"
        }
    }
}