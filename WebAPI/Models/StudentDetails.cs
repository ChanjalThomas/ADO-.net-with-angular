using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class StudentDetails
    {
        public int DetailId { get; set; }
        public int StudentId { get; set; }
        public string Address { get; set; }
        public int DepartmentId { get; set; }
        public bool Gender { get; set; }
    }
}
