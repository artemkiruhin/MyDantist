namespace Domain.Models
{
    public class Treatment
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid AppointmentId { get; set; }
        public Appointment? Appointment { get; set; }
        public string ProcedureName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public decimal Cost { get; set; }

        public static Treatment Create(Guid id, Guid appointmentId, Appointment? appointment, string procedureName, string? description, decimal cost)
        {
            return new Treatment()
            {
                Id = id,
                AppointmentId = appointmentId,
                Appointment = appointment,
                ProcedureName = procedureName,
                Description = description,
                Cost = cost
            };
        }
    }
}
