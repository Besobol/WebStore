using WebStore.Core.Models;

namespace WebStore.Core.Contracts
{
    public interface IAdminService
    {
        Task AddBookAsync(BookModel book);

        Task AddPublisherAsync(PublisherModel publisher);

        Task AddAuthorAsync(AuthorModel author);

        Task AddStoreAsync(StoreModel store);
    }
}
