﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TuringTechnical.Models
{
    public class Course
    {
        [Key]
        public int ID { get; set; }
        public string Title {get;set;}
        public string Description { get; set; }
        public int CreditHours { get; set; }
        public int MaxClassSize { get; set; } //ClassMax=maximum number of students in class
        public int MinClassSize { get; set; } //ClassMin = minimum number students for class to go
        public ICollection<Course_Student> Course_Students { get; set; }
    }
}