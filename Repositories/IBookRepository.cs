using ProjectAPI.Models;

namespace ProjectAPI.Repositories
{
    public interface IBookRepository
    {
        Task<IEnumerable<BookApiModel>> Get();
        Task<BookApiModel> Get(int id);
        Task<BookApiModel> Create(BookApiModel book);
        Task Update(BookApiModel book);
        Task Delete(int id);
    }
}
