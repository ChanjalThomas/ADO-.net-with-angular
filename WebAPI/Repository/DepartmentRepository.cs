using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.InterfaceRepositry;
using WebAPI.Models;
using System.Reflection;

namespace WebAPI.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly IConfiguration _configuration;
        public DepartmentRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public DataTable Getdata()
        {
            string query = @"Select DepartmentId, DepartmentName from Department";
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

            return table;
        }
        public string Create(Department department)
        {
            string query = " Insert Into Department values " +
                "('" + department.DepartmentName + "')";
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
            return "Successfully Created";
        }
         public bool Update(Department department)
         {
            bool result = false;
            string query = " update dbo.Department set " +
                "DepartmentName = '" + department.DepartmentName + "' where DepartmentId = " + department.DepartmentId;
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
                    result = true;

                    myReader.Close();
                    myCon.Close();
                }
            }
            return result;
         }
        public bool DeleteDep(int id)
        {
            bool result = false;
            string query = "Delete from Department  where DepartmentId = " + id;
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
                    result = true;

                    myReader.Close();
                    myCon.Close();
                }
            }
            return result;
        }
    }
}
