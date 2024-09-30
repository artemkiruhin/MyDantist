using Domain.Models;
using Infrastructure.Database.Repositories.Base;

namespace Infrastructure.Database.Repositories.Implementations
{
    public class UserRepository : CrudRepositoryBase<User>
    {
        public UserRepository(DantistClinicDbContext context) : base(context)
        {
        }
    }
}
