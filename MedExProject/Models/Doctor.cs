using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MedExProject.Models
{
    [Table("Doctor")]
    public class Doctor
    {
        [Key]
        public int DoctorID { get; set; }
        public string DoctorFirstName { get; set; }
        public string DoctorLastName { get; set; }
        public string DoctorPhone { get; set; }
        [EmailAddress]
        public string DoctorEmail { get; set; }

    }
}