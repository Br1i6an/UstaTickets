using ustaTickets.Models;
namespace ustaTickets.Data.Services
{
    public interface ICinemaService
    {
        Task<IEnumerable<Cinema>> GetAllAsync();
        Task AddAsync(Cinema cinema);

        Task<Cinema> UpdateAsync(int id, Cinema newCinema);
        void Delete(int id);
        Task<Cinema> GetByIdAsync(int id);
    }
}
