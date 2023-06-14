using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstraction
{
    public interface IClinicDbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<ClinicContact> ClinicContacts { get; set; }
        public DbSet<ClinicSocialNetwork> ClinicSocialNetworks { get; set; }
        public DbSet<DoctorSocialMedia> DoctorSocialMedias { get; set; }
        public DbSet<NetworkType> NetworkTypes { get; set; }
        public int SaveChanges(bool acceptAllChangesOnSuccess);
    }
}
