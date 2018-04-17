using System;
using System.Collections.Generic;
using Undefine.Domain.IRepository;
using Undefine.Domain.Model;

namespace Undefine.Repository.Repositories
{
    public class Sys_UserRepository : BaseRepository<Sys_User>, ISys_UserRepository
    {
        public Sys_UserRepository(IEFUnitOfWork uow):base(uow)
        {
            UnitOfWork=uow;
        }

        public IEnumerable<Sys_User> GetUsers(int index, int size)
        {
            throw new NotImplementedException();
        }
    }
}
