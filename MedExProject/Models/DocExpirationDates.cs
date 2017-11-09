using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MedExProject.Models
{
    [Table("DocExpirationDates")]
    public class DocExpirationDates
    {
        [Key]
        public DateTime MedicalLicenseExpirDate { get; set; }
        public DateTime DEACertExpirDate { get; set; }
        public DateTime PharmacyCertExpirDate { get; set; }
        public DateTime BoardCertExpirDate { get; set; }
        public DateTime HospConfLetterExpir { get; set; }
        public DateTime CLIACertExpirDate { get; set; }
        public DateTime BusinessLicenseForPractExpirDate { get; set; }
        public DateTime DriversLicenseExpirDate { get; set; }

        [ForeignKey("Doctor")]
        public virtual int DoctorID { get; set; }
       
    }
}