using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MedExProject.Models
{
    [Table("Doctor_Certificate")]
    public class Doctor_Certificate
    {
        [Key]
        [Column(Order = 0)]
        public int DoctorID { get; set; }
        [Key]
        [Column(Order = 1)]
        public int CertID { get; set; }

        public DateTime ExpirDate { get; set; }
    }
}