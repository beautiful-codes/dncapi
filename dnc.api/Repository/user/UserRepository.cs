using dnc.api.Persistance;
using dnc.api.Persistance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dnc.api.Repository.user
{
    public class UserRepository : Repository<User> ,IUserRepository
    {
        private readonly ApiDbContext _context;
        public UserRepository(ApiDbContext context): base(context)
        {
            _context = context;
        }
    }
}
