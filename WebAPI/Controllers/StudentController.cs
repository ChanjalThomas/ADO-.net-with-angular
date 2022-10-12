using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.ServiceInterface;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IDepartmentService _departmentService;
        private readonly IMarkService _markService;
        public StudentController(IConfiguration configuration, IDepartmentService departmentService, IMarkService markService)
        {
            _configuration = configuration;
            _departmentService = departmentService;
            _markService = markService; 
        }

        [HttpGet]
        public JsonResult Get()
        {
            string query = @"Select StudentId, FullName, Class from Student";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("StudentAppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult(table);
        }


        [HttpPost]
        public JsonResult Post(Student objStudent)
        {
            string query = @"Insert into Student values 
                ('" + objStudent.FullName + "','" + objStudent.Class + "')";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("StudentAppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Added Successfully");
        }

        [HttpPut]
        public JsonResult Put(Student objStudent)
        {
            string query = @"Update Student set 
                FullName = '" + objStudent.FullName + @"',
                Class='" + objStudent.Class + "' where StudentId = " + objStudent.StudentId;
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("StudentAppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Updated Successfully");
        }


        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            string query = @"Delete from Student where StudentId = " + id;
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("StudentAppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Deleted Successfully");
        }





        [HttpGet]
        [Route("Getdata")]
        public JsonResult Getdata()
        {
            return new JsonResult(_departmentService.Getdata());
        }


        [HttpPost]
        [Route("Create")]
        public JsonResult Create(Department department)
        {
            return new JsonResult(_departmentService.Create(department));
        }

        [HttpPut]
        [Route("Update")]
        public JsonResult Update(Department department)
        {
            return new JsonResult(_departmentService.Update(department));
        }
        [HttpDelete]
        [Route("DeleteDep")]
        public JsonResult DeleteDep(int id)
        {
            return new JsonResult(_departmentService.DeleteDep(id));
        }



        /*[HttpGet]
        [Route("GetMark")]
        public JsonResult GetMark()
        {
            return new JsonResult(_markService.GetMark());
        }
*/
    }
}
