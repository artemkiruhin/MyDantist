using Domain.Models;
using Infrastructure.Database.Repositories.Base;

namespace Infrastructure.Database.Repositories.Implementations
{
    public class TreatmentRepository : CrudRepositoryBase<Treatment>
    {
        public TreatmentRepository(DantistClinicDbContext context) : base(context)
        {
        }
    }
}
