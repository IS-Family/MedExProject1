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
        public String DoctorFirstName { get; set; }
        public String DoctorLastName { get; set; }
        public String DoctorPhone { get; set; }
        [EmailAddress]
        public String DoctorEmail { get; set; }

    }
}