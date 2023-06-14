namespace Domain.Entities;

public class ClinicSocialNetwork : SocialMediaBase
{
    public ClinicContact ClinicContact { get; set; }
    public Guid ClinicContactId { get; set; }

}
