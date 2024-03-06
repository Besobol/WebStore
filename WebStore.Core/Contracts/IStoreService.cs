using WebStore.Core.Models;

namespace WebStore.Core.Contracts
{
    public interface IStoreService
    {
        Task<IEnumerable<BookCardModel>> GetBookCardsPageAsync(int page, string query, int pageSize);

    }
}
