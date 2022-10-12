using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.ServiceInterface;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetailController : ControllerBase
    {
        public readonly IDetailService _detailService;
        public DetailController(IDetailService detailService)
        {
            _detailService = detailService;
        }


        [HttpGet]
        [Route("GetDetails")]
        public JsonResult GetDetails()
        {
            return new JsonResult(_detailService.GetDetails());
        }


        [HttpPost]
        [Route("CreateDetails")]
        public JsonResult CreateDetails(StudentDetails detail)
        {
            return new JsonResult(_detailService.CreateDetails(detail));
        }

        [HttpPut]
        [Route("UpdateDetails")]
        public JsonResult UpdateDetails(StudentDetails detail)
        {
            return new JsonResult(_detailService.UpdateDetails(detail));
        }


        [HttpDelete]
        [Route("DeleteDetails")]
        public JsonResult DeleteDetails(int id)
{
            return new JsonResult(_detailService.DeleteDetails(id));
        }
    }
}
