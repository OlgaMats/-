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
    [Route("/author")]
    public class AuthorController : ControllerBase
    {
        [HttpPut]
        public Author Create(Author author)
        {
            Storage.AuthorStorage.Create(author);
            return author;
        }

        [HttpGet]
        public Author Read(int authorId)
        {
            return Storage.AuthorStorage.Read(authorId);
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

        [HttpGet("RegAuthors")]
        public string RegAuthors(string str)
        {
            return str;// "Метод регистрации на выставке"
        }

        [HttpGet("Transfer")]
        public string Transfer(string str)
        {
            return str;//"Метод передачи экспонатов"
        }
    }
}