﻿using HospitalProject2.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalProject2.Models
{
    public class Donations
    {
        [Key]
        public int donation_Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        [ForeignKey("Department")]
        public int department_Id { get; set; }
        public string Phone { get; set; }
        public decimal Amount { get; set; }
    }

    public class DonationsDto
    {
        public int donation_Id { get; set; }
        [Display(Name = "Donor Name")]
        public string Name { get; set; }
        public string Email { get; set; }
        public int department_Id { get; set; }
        public string Phone { get; set; }
        public decimal Amount { get; set; }
    
    }
}
