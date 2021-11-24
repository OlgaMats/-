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
    [Route("/staff")]
    public class StaffController : ControllerBase
    {

        [HttpPut]
        public Staff Create(Staff staff)
        {
           Storage.StaffStorage.Create(staff);// Метод создания
            return staff;
        }

        [HttpGet]
        public Staff Read(int staffId)
        {
            return Storage.StaffStorage.Read(staffId);
        }

        [HttpPatch]
        public Staff Update(int staffId, Staff newStaff)
        {
            return Storage.StaffStorage.Update(staffId, newStaff);
        }

        [HttpDelete]
        public bool Delete(int staffId)
        {
            return Storage.StaffStorage.Delete(staffId);
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