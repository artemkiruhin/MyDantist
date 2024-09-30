using Domain.Models;
using Infrastructure.Database.Repositories.Base;

namespace Infrastructure.Database.Repositories.Implementations
{
    public class AppointmentRepository : CrudRepositoryBase<Appointment>
    {
        public AppointmentRepository(DantistClinicDbContext context) : base(context)
        {
        }
    }
}
