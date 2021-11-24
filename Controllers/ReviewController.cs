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
        public Review Update(int reviewId, Review newReview)
        {
            return Storage.ReviewStorage.Update(reviewId, newReview);
        }

        [HttpDelete]
        public bool Delete(int reviewId)
        {
            return Storage.ReviewStorage.Delete(reviewId);
        }
    }
}