using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace University.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public int Credit { get; set; }
        [Required]
        public double CGPA { get; set; }
        [Required]
        public int Dept_id { get; set; }
        public string Dept_name { get; set; }
    }
}