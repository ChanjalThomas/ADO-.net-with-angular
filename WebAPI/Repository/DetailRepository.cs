using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.InterfaceRepositry;
using WebAPI.Models;

namespace WebAPI.Repository
{
    public class DetailRepository : IDetailRepository
    {
        public readonly IConfiguration _configuration;
        public DetailRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public DataTable GetDetails()
        {
            string query = @"Select sd.DetailId, s.FullName,sd.Address, d.DepartmentName, sd.Gender From StudentDetails sd join                 Student s on sd.StudentId= s.StudentId join Department d On sd.DepartmentId = d.DepartmentId";
            DataTable data = new DataTable();
            string conn = _configuration.GetConnectionString("StudentAppCon");
            SqlDataReader myReader;
            using (SqlConnection mycon = new SqlConnection(conn))
            {
                mycon.Open();
                using (SqlCommand command = new SqlCommand(query, mycon))
                {
                    myReader = command.ExecuteReader();
                    data.Load(myReader);
                    myReader.Close();
                    mycon.Close();
                }
            }
            return data;
        }
        public string CreateDetails(StudentDetails detail)
        {
            string query = @"Insert INTO StudentDetails (StudentId, Address, DepartmentId, Gender)
                                Values " + (detail.StudentId, detail.Address, detail.DepartmentId, detail.Gender);
            DataTable data = new DataTable();
            string conn = _configuration.GetConnectionString("StudentAppCon");
            SqlDataReader reader;
            using (SqlConnection mycon = new SqlConnection(conn))
            {
                mycon.Open();
                using (SqlCommand command = new SqlCommand(query, mycon))
                {
                    reader = command.ExecuteReader();
                    data.Load(reader);
                    reader.Close();
                    mycon.Close();
                }
            }
            return "Successfully Created";
        }
        public bool UpdateDetails(StudentDetails detail)
        {
            bool result = false;
            string query = @"Update StudentDetails Set Address ='" + detail.Address + "', Gender ='" + detail.Gender +"' where DetailId = " + detail.DetailId;
            DataTable data = new DataTable();
            string conn = _configuration.GetConnectionString("StudentAppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(conn))
            {
                myCon.Open();
                using (SqlCommand command = new SqlCommand(query, myCon))
                {
                    myReader = command.ExecuteReader();
                    data.Load(myReader);
                    result = true;

                    myReader.Close();
                    myCon.Close();
                }
            }
            return result;
        }


        public bool DeleteDetails(int id)
        {
            bool result = false;
            string query = @"Delete from StudentDetails  where DetailId = " + id;
            DataTable data = new DataTable();
            string conn = _configuration.GetConnectionString("StudentAppCon");
            SqlDataReader reader;
            using (SqlConnection mycon = new SqlConnection(conn))
            {
                mycon.Open();
                using (SqlCommand command = new SqlCommand(query, mycon))
                {
                    reader = command.ExecuteReader();
                    data.Load(reader);
                    result = true;
                    reader.Close();
                    mycon.Close();
                }
            }
            return result;
        }
    }
}
