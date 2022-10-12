using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.InterfaceRepositry
{
    public interface IDetailRepository
    {
        public DataTable GetDetails();
        public string CreateDetails(StudentDetails detail);
        public bool UpdateDetails(StudentDetails detail);
        public bool DeleteDetails(int id);
    }
}
