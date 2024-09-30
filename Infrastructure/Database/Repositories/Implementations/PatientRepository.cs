using Domain.Models;
using Infrastructure.Database.Repositories.Base;

namespace Infrastructure.Database.Repositories.Implementations
{
    public class PatientRepository : CrudRepositoryBase<Patient>
    {
        public PatientRepository(DantistClinicDbContext context) : base(context)
        {
        }
    }
}
