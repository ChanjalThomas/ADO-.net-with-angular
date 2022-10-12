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
    public class DepartmentContollerStudent : ControllerBase
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentContollerStudent(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet]
        [Route("getlocations")]
        public JsonResult Getdata()
        {
            return new JsonResult(_departmentService.Getdata());
        }
        [HttpPost]
        public JsonResult Create(Department department)
        {
            return new JsonResult(department);
        }
        [HttpPut]
        public JsonResult Update(Department department)
        {
            return new JsonResult(department);
        }
        [HttpDelete]
        public JsonResult DeleteDep(int id)
        {
            return new JsonResult(id);
        }
    }
}
