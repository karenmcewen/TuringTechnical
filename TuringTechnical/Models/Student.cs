using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TuringTechnical.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        [DisplayName("Student Name")]
        public string Name { get; set; }
        //can change the format that is displayed by putting a [] above the definition
        [DisplayName("Birthday MM/DD/YYYY")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime BirthDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime EnrollDate { get; set; }
        public string Email { get; set; }
        [DisplayFormat(DataFormatString = "{0:###-###-####}")]
        public long Phone { get; set; }

        public ICollection<Course_Student> Course_Students { get; set; }

    }
}