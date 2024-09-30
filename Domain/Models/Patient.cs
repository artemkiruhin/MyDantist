namespace Domain.Models
{
    public class Patient
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public string? MedicalHistory { get; set; }
        public string? AllergiesAndReactions { get; set; }
        public List<Appointment> Appointments { get; set; } = new List<Appointment>();

        public static Patient Create(Guid id, Guid userId, User? user, string? medicalHistory, string? allergiesAndReactions, List<Appointment> appointments)
        {
            return new Patient()
            {
                Id = id,
                UserId = userId,
                User = user,
                MedicalHistory = medicalHistory,
                AllergiesAndReactions = allergiesAndReactions,
                Appointments = appointments
            };
        }
    }
}
