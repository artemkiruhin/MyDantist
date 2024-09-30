using Domain.Models;
using Infrastructure.Database.Repositories.Base;

namespace Infrastructure.Database.Repositories.Implementations
{
    public class EmployeeRepository : CrudRepositoryBase<Employee>
    {
        public EmployeeRepository(DantistClinicDbContext context) : base(context)
        {
        }
    }
}
