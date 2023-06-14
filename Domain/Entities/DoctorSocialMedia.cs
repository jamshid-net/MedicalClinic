using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class DoctorSocialMedia: SocialMediaBase
{
    [ForeignKey("DoctorSocialMedia")]
    public Doctor Doctor { get; set; }
    public Guid DoctorId { get; set; }
}
