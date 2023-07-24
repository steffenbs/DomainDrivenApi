using Domain.Common;
using Domain.Common.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interface
{
    public interface IDomainRepository<T, TId> where T : AggregateRoot<TId>
    {
        Task<T> LoadAsync(TId id);
        Task<T> AddAsync(T item, int loggedInPersonId);
        Task ApplyChangesAsync(IEnumerable<IDomainEvent> changes, int loggedInPersonId);
    }
}
