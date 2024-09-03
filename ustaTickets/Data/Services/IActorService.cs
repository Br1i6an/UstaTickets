using ustaTickets.Models;
namespace ustaTickets.Data.Services
{
    public interface IActorService
    {
        Task<IEnumerable<Actor>> GetAllAsync();
        Task AddAsync(Actor actor);

        Task<Actor> UpdateAsync(int id, Actor newActor);
        void Delete(int id);
        Task<Actor> GetByIdAsync(int id);
    }
}
