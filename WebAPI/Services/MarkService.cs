using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.InterfaceRepositry;
using WebAPI.Models;
using WebAPI.ServiceInterface;

namespace WebAPI.Services
{
    public class MarkService : IMarkService
    {
        public readonly IMarkRepository _markRepository;
        public MarkService(IMarkRepository markRepository)
        {
            _markRepository = markRepository;
        }


        public DataTable GetMark()
        {
            return _markRepository.GetMark();
        }

        public bool DeleteMark(int id)
        {
            return _markRepository.DeleteMark(id);
        }

        public string CreateMark(Marks marks)
        {
            return _markRepository.CreateMark(marks);
        }

        public DataTable Student(Student student)
        {
            return _markRepository.Student(student);
        }

        public DataTable Department(Department department)
        {
            return _markRepository.Department(department);
        }

        public bool UpdateMark(Marks marks)
        {
            return _markRepository.UpdateMark(marks);
        }
    }
}
