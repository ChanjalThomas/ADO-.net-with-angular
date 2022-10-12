using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Marks
    {
        public int MarkId { get; set; }
        public int StudentId { get; set; }
        public int DepartmentId { get; set; }
        public decimal Mark { get; set; }
    }
}
