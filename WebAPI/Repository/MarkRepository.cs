using Microsoft.Extensions.Configuration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.InterfaceRepositry;
using WebAPI.Models;

namespace WebAPI.Repository
{
    public class MarkRepository : IMarkRepository
    {
        private readonly IConfiguration _configuration;
        public MarkRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public DataTable GetMark()
        {
            string query = @"Select m.MarkId, s.FullName, d.DepartmentName, m.Mark From Marks m join Student s on m.StudentId= s.StudentId join Department d On m.DepartmentId = d.DepartmentId";
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

        public bool DeleteMark(int id)
        {
            bool result = false;
            string query = @"Delete from Marks  where MarkId = " + id;
            DataTable data = new DataTable();
            string conn = _configuration.GetConnectionString("StudentAppCon");
            SqlDataReader reader;
            using(SqlConnection mycon = new SqlConnection(conn))
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

        public string CreateMark(Marks marks)
        {
            string query = @"Insert INTO Marks (StudentId, DepartmentId, Mark)
                                Values "+(marks.StudentId, marks.DepartmentId, marks.Mark);
            DataTable data = new DataTable();
            string conn = _configuration.GetConnectionString("StudentAppCon");
            SqlDataReader reader;
            using(SqlConnection mycon = new SqlConnection(conn))
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



        public DataTable Student(Student student)
        {
            string query = @"Select FullName from Student";
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

        public DataTable Department(Department department)
        {
            string query = @"Select DepartmentName from Department";
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


        public bool UpdateMark(Marks marks)
        {
            bool result = false;
            string query = @"Update Marks Set Mark ='" + marks.Mark + "' where MarkId = " + marks.MarkId;
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
    }
}
