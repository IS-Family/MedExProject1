using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MedExProject.Models
{
    [Table("Certificate")]
    public class Certificate
    {
        [Key]
        public int CertID { get; set; }
        public String CertName { get; set; }
    }
}