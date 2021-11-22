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
    [Route("/review")]
    public class ReviewController : ControllerBase
    {
        [HttpPut]
        public Review Create(Review review)
        {
            Storage.ReviewStorage.Create(review);
            return review;// Метод создания
        }

        [HttpGet]
        public Review Read(int reviewId)
        {
            return Storage.ReviewStorage.Read(reviewId);// Метод чтения
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