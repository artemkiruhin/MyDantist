namespace Domain.Models
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string? Patronymic { get; set; } = null;
        public string Email { get; set; } = string.Empty;
        public DateTime Registered { get; set; } = DateTime.Now;
        public DateOnly Birthday { get; set; } = DateOnly.MinValue;
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public Role Role { get; set; } = Role.Patient;


        public static User Create(Guid id, string name, string surname, string? patronymic, string email, DateTime registered, DateOnly birthday, string username, string passwordHash, Role role)
        {
            return new User
            {
                Id = id,
                Name = name,
                Surname = surname,
                Patronymic = patronymic,
                Email = email,
                Registered = registered,
                Birthday = birthday,
                Username = username,
                PasswordHash = passwordHash,
                Role = role
            };
        }
    }
}
