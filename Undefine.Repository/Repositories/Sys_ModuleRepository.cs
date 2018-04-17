using Undefine.Domain.IRepository;
using Undefine.Domain.Model;

namespace Undefine.Repository.Repositories
{
    public class Sys_ModuleRepository : BaseRepository<Sys_Module>, ISys_ModuleRepository
    {
        public Sys_ModuleRepository(IEFUnitOfWork uow):base(uow)
        {
        }
    }
}
