namespace Domain.Models
{
    public class Employee
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public DateOnly HireDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public string Position { get; set; } = string.Empty;
        public string? Specialization { get; set; }
        
        
        public static Employee Create(Guid id, Guid userId, User? user, DateOnly hireDate, string position, string? specialization)
        {
            return new Employee()
            {
                Id = id,
                UserId = userId,
                User = user,
                HireDate = hireDate,
                Position = position,
                Specialization = specialization
            };
        }
    }
}
