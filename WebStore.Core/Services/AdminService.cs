using WebStore.Core.Contracts;
using WebStore.Core.Models;
using WebStore.Infrastructure.Data.Common;
using WebStore.Infrastructure.Data.Models;

namespace WebStore.Core.Services
{
    public class AdminService : IAdminService
    {
        private readonly IRepository repository;

        public AdminService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task AddAuthorAsync(AuthorModel author)
        {
            Author model = new()
            {
                Name = author.Name,
                Description = author.Description
            };

            await repository.AddAsync(model);
            await repository.SaveChangesAsync();
        }

        public async Task AddBookAsync(BookModel book)
        {
            Book model = new()
            {
                Title = book.Title,
                Summery = book.Summery,
                Price = book.Price,
                ImgPath = book.ImgPath,
            };

            await repository.AddAsync(model);
            await repository.SaveChangesAsync();
        }

        public async Task AddPublisherAsync(PublisherModel publisher)
        {
            Publisher model = new()
            {
                Name = publisher.Name,
                Description = publisher.Description
            };

            await repository.AddAsync(model);
            await repository.SaveChangesAsync();
        }

        public async Task AddStoreAsync(StoreModel store)
        {
            Store model = new()
            {
                Name = store.Name,
                Website = store.Website,
            };

            await repository.AddAsync(model);
            await repository.SaveChangesAsync();
        }
    }
}
