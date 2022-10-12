using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.ServiceInterface;
using WebAPI.InterfaceRepositry;
using WebAPI.Models;

namespace WebAPI.Services
{
    public class DepartmentService :  IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public DataTable Getdata()
        {
            return _departmentRepository.Getdata();
        }
        public string Create(Department department)
        {
           return _departmentRepository.Create(department);
        }
        public bool Update(Department department)
        {
            return _departmentRepository.Update(department);
        }
        public bool DeleteDep(int id)
        {
            return _departmentRepository.DeleteDep(id);
        }
    }
}
