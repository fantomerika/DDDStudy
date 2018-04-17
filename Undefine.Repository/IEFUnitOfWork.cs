using Microsoft.EntityFrameworkCore;
using Undefine.Domain.IRepository;

namespace Undefine.Repository
{
    public interface IEFUnitOfWork: IUnitOfWorkRepositoryContext
    {
        DbContext Context { get; }
    }
}
