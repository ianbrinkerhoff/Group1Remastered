using System;
using System.Collections.Generic;
using System.Text;
using Typing.Models;

namespace Typing.DataAccess.Data.Repository.IRepository
{
    public interface IUserRepository : IRepository<User>
    {
        void Update(User user);
    }
}
