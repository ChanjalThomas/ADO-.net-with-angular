using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.ServiceInterface
{
    public interface IDepartmentService
    {
        public DataTable Getdata();
        public string Create(Department department);
        public bool Update(Department department);
        public bool DeleteDep(int id);
    }
}
