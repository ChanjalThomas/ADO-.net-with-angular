using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.ServiceInterface;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarkController : ControllerBase
    {
        public readonly IMarkService _markService;
        public MarkController(IMarkService markService)
        {
            _markService = markService;
        }


        [HttpGet]
        [Route("GetMark")]
        public JsonResult GetMark()
        {
            return new JsonResult(_markService.GetMark());
        }

        [HttpPost]
        [Route("CreateMark")]
        public JsonResult CreateMark(Marks marks)
        {
            return new JsonResult(_markService.CreateMark(marks));
        }

        [HttpGet]
        [Route("Student")]
        public JsonResult Student(Student student)
        {
            return new JsonResult(_markService.Student(student));
        }

        [HttpGet]
        [Route("Department")]
        public JsonResult Department(Department department)
        {
            return new JsonResult(_markService.Department(department));
        }

        [HttpPut]
        [Route("UpdateMark")]
        public JsonResult UpdateMark(Marks marks)
        {
            return new JsonResult(_markService.UpdateMark(marks));
        }

        [HttpDelete]
        [Route("DeleteMark")]
        public JsonResult DeleteMark(int id)
        {
            return new JsonResult(_markService.DeleteMark(id));
        }
    }
}
