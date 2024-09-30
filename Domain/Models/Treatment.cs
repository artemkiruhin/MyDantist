namespace Domain.Models
{
    public class Treatment
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid AppointmentId { get; set; }
        public Appointment? Appointment { get; set; }
        public Guid PatientId { get; set; }
        public Patient? Patient { get; set; }
        public Guid EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        public string ProcedureName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public decimal Cost { get; set; }

        public static Treatment Create(Guid id, Guid appointmentId, Appointment? appointment, Guid patientId, Patient? patient, Guid employeeId, Employee? employee, string procedureName, string? description, decimal cost)
        {
            return new Treatment()
            {
                Id = id,
                AppointmentId = appointmentId,
                Appointment = appointment,
                PatientId = patientId,
                Patient = patient,
                EmployeeId = employeeId,
                Employee = employee,
                ProcedureName = procedureName,
                Description = description,
                Cost = cost
            };
        }
    }
}
