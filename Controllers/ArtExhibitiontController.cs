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
        [HttpGet]
        [Route("/client/ViewingExhibits")]
        public string ViewingExhibits(string str)
        {
            return "Метод выбора просмотра экспонатов";
        }

        [HttpGet]
        [Route("/client/Review")]
        public string Review(string str)
        {
            return "Метод оценки выставки";
        }

        [HttpGet]
        [Route("/client/Information")]
        public string Information(string str)
        {
            return "Метод ознакомления со сведениями о выставке";
        }

    }

    [ApiController]
    [Route("/author")]
    public class AuthorController : ControllerBase
    {
        [HttpGet]
        [Route("/author/RegAuthors")]
        public string RegAuthors(string str)
        {
            return "Метод регистрации на выставке";
        }

        [HttpPost]
        [Route("/author/Transfer")]
        public string Transfer()
        {
            return "Метод передачи экспонатов";
        }
    }

    [ApiController]
    [Route("/admin")]
    public class AdminController : ControllerBase
    {
        [HttpGet]
        [Route("/admin/Prices")]
        public string Prices(string str)
        {
            return "Метод установления цен на билеты";
        }

        [HttpGet]
        [Route("/admin/ReviewAnalytics")]
        public string ReviewAnalytics()
        {
            return "Метод анализирования отзывов";
        }

        [HttpGet]
        [Route("/admin/Timetable")]
        public string Timetable(string str)
        {
            return "Метод составления графика (расписания)";
        }
    }

    [ApiController]
    [Route("/staff")]
    public class StaffController : ControllerBase
    {
        [HttpGet]
        [Route("/staff/EditInformation")]
        public string EditInformation(string str)
        {
            return "Метод редактирования информации об экспонатах";
        }

        [HttpGet]
        [Route("/staff/CheckSafety")]
        public string CheckSafety()
        {
            return "Метод проверки экспонатов на сохранность";
        }

        [HttpGet]
        [Route("/staff/RegVisitors")]
        public string RegVisitors(string str)
        {
            return "Метод регистрации посетителей";
        }

        [HttpGet]
        [Route("/staff/RegNewExhibits")]
        public string RegNewExhibits(string str)
        {
            return "Метод регистрации новых экспонатов";
        }
    }
}