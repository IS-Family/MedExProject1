using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("First Name")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public String DoctorFirstName { get; set; }
        [DisplayName("Last Name")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public String DoctorLastName { get; set; }
        [DisplayName("Phone")]
        public String DoctorPhone { get; set; }
        [EmailAddress]
        [DisplayName("Email")]
        public String DoctorEmail { get; set; }

    }
}