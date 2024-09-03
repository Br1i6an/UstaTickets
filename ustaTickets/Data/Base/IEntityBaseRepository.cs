using ustaTickets.Models;

namespace ustaTickets.Data.Base
{
    public interface EntityBaseRepository<T> where T : class, IEntityBase, new()
    {
    }
}
