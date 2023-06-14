namespace Domain.Entities
{
    public class ClinicContact
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Uri Location { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
