using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.InterfaceRepositry;
using WebAPI.Models;
using WebAPI.Repository;
using WebAPI.ServiceInterface;

namespace WebAPI.Services
{
    public class DetailService : IDetailService
    {
        public readonly IDetailRepository _detailRepository;
        public DetailService(IDetailRepository detailRepository)
        {
            _detailRepository = detailRepository;
        }
        public DataTable GetDetails()
        {
            return _detailRepository.GetDetails();
        }
        public string CreateDetails(StudentDetails detail)
        {
            return _detailRepository.CreateDetails(detail);
        }
        public bool UpdateDetails(StudentDetails detail)
        {
            return _detailRepository.UpdateDetails(detail);
        }
        public bool DeleteDetails(int id)
        {
            return _detailRepository.DeleteDetails(id);
        }
    }
}
