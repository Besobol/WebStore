using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
using WebStore.Core.Contracts;
using WebStore.Core.Models;
using WebStore.Infrastructure.Data.Common;
using WebStore.Infrastructure.Data.Models;

namespace WebStore.Core.Services
{
    public class StoreService : IStoreService
    {
        private readonly IRepository repository;

        public StoreService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<IEnumerable<BookCardModel>> GetBookCardsPageAsync(int page, string query, int pageSize)
        {
            return await repository.AllReadOnly<Book>()
                .Where(b => b.Title.Contains(query))
                .Skip(page - 1 * pageSize)
                .Take(pageSize)
                .Select(b => new BookCardModel()
                {
                    Id = b.Id,
                    Title = b.Title,
                    Autor = string.Join(", ",
                        b.AuthorsBooks
                        .Where(ab => ab.BookId == b.Id)
                        .Select(ab => ab.Author.Name)),
                    ImgPath = b.ImgPath,
                    Price = b.Price
                })
                .OrderBy(b => b.Id)
                .ToListAsync();
        }
    }
}
