using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.ServiceInterface
{
    public interface IMarkService
    {
        public DataTable GetMark();
        public bool DeleteMark(int id);
        public string CreateMark(Marks marks);
        public DataTable Student(Student student);
        public DataTable Department(Department department);
        public bool UpdateMark(Marks marks);
    }
}
