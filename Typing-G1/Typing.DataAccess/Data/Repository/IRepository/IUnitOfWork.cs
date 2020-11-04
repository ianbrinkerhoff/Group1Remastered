using System;
using System.Collections.Generic;
using System.Text;

namespace Typing.DataAccess.Data.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository User { get; }

        void Save();
    }
}
