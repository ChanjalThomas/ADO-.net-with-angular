using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.InterfaceRepositry
{
    public interface IMarkRepository
    {
        public DataTable GetMark();
        public string CreateMark(Marks marks);
        public DataTable Student(Student student);
        public DataTable Department(Department department);
        public bool UpdateMark(Marks marks);
        public bool DeleteMark(int id);
    }
}
