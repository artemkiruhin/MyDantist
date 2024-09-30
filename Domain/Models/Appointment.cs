namespace Domain.Models
{
    public class Appointment
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid PatientId { get; set; }
        public Patient? Patient { get; set; }
        public Guid DentistId { get; set; }
        public Employee? Dentist { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        public string? Purpose { get; set; }
        public string? Notes { get; set; }

        public static Appointment Create(Guid id, Guid patientId, Patient? patient, Guid dentistId, Employee? dentist, DateTime appointmentDateTime, string? purpose, string? notes)
        {
            return new Appointment()
            {
                Id = id,
                PatientId = patientId,
                Patient = patient,
                DentistId = dentistId,
                Dentist = dentist,
                AppointmentDateTime = appointmentDateTime,
                Purpose = purpose,
                Notes = notes
            };
        }
    }
}
