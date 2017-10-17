using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TuringTechnical.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        //can change the format that is displayed by putting a [] above the definition
        [DisplayFormat(DataFormatString = "{0:mm/dd/yyyy}")]
        public DateTime BirthDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:mm/dd/yyyy}")]
        public DateTime EnrollDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

    }
}