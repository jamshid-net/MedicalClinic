using Domain.Enum;

namespace Domain.Entities;

public class Doctor: User
{
    public string Speciality { get; set; }   
}
