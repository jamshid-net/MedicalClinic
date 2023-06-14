using Application.Abstraction;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DataAccess;

public class ClinicDbContext:IdentityDbContext<IdentityUser>, IClinicDbContext
{
    public ClinicDbContext(DbContextOptions<ClinicDbContext> options)
        :base(options)
    {
        
    }

    public ClinicDbContext()
    {
        
    }
    public  DbSet<Doctor> Doctors { get; set; }
    public  DbSet<ClinicContact> ClinicContacts { get; set; }
    public  DbSet<ClinicSocialNetwork> ClinicSocialNetworks { get; set; }
    public  DbSet<DoctorSocialMedia> DoctorSocialMedias { get; set; }
    public  DbSet<NetworkType> NetworkTypes { get; set; }
    public  DbSet<User> Users { get; set; }
    

}
