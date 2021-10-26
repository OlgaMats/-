using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Art_exhibition.Controllers
{
    [ApiController]
    [Route("/admin")]
    public class AdminController : ControllerBase
    {
        [HttpGet("Prices")]
        public string Prices(string str)
        {
            return str;//"Метод установления цен на билеты"
        }

        [HttpGet("ReviewAnalytics")]
        public string ReviewAnalytics(string str)
        {
            return str;// "Метод анализирования отзывов"
        }

        [HttpGet("Answer")]
        public string Answer(string str)
        {
            return str;// "Метод ответа на вопросы"
        }

        [HttpGet("TimetableAdress")]
        public string TimetableAdress(string str)
        {
            return str;// "Метод составления графика (расписания), адреса"
        }
    }
}