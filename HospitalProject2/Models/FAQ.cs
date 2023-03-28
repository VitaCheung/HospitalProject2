﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HospitalProject2.Models
{
    public class FAQ
    {
        [Key]
        public int FAQ_Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        [ForeignKey("Departments")]
        public int department_id { get; set; }
        public virtual Departments Departments { get; set; }

    }

    public class FAQDto
    {
        public int FAQ_Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public int department_id { get; set; }
        
    }
}