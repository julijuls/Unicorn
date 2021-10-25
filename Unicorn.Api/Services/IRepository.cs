using System.Collections.Generic;
using System.Threading.Tasks;

namespace Unicorn.Api.Services
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
    }
}
