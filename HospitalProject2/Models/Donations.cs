using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [ForeignKey("Departments")]
        public int department_id { get; set; }
        public virtual Departments Departments { get; set; }
        public string Phone { get; set; }
        public decimal Amount { get; set; }
    }

    public class DonationsDto
    {
        public int donation_Id { get; set; }
        
        public string Name { get; set; }
        public string Email { get; set; }
        public int department_id { get; set; }
        public string Phone { get; set; }
        public decimal Amount { get; set; }
        

       
    }
}
