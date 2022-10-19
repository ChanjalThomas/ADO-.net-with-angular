using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class StudentDetails
    {
        public int? DetailId { get; set; }
/*
        [Required(ErrorMessage = "*Please select StudentId Required")]*/
        public int StudentId { get; set; }
/*
        [Required(ErrorMessage = "*Please enter Address Required")]*/
        public string Address { get; set; }

       /* [Required(ErrorMessage = "*Please select DepartmentId Required")]*/
        public int DepartmentId { get; set; }


       /* [Required(ErrorMessage = "*Please select Gender Required")]*/
        public string Gender { get; set; } 
    }
}
