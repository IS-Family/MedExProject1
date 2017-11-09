using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MedExProject.Models;
using System.Data.Entity;

namespace MedExProject.DAL
{
    public class MedEx : DbContext
    {
        public MedEx() : base("MedEx")
        {

        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DocExpirationDates> DocExpirationDatesEach { get; set; }
    }
}