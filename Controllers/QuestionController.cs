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
    [Route("/question")]
    public class QuestionController : ControllerBase
    {
        [HttpPut]
        public Question Create(Question question)
        {
            Storage.QuestionStorage.Create(question);
            return question;// Метод создания
        }

        [HttpGet]
        public Question Read(int questionId)
        {
            return Storage.QuestionStorage.Read(questionId);// Метод чтения
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