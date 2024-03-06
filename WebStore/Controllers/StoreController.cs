using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebStore.Core.Contracts;
using static WebStore.Core.Constants.ConstantValues;


namespace WebStore.Controllers
{
    public class StoreController : BaseController
    {
        private readonly IStoreService storeService;

        public StoreController(IStoreService _storeService)
        {
            storeService = _storeService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index(int page = 0, string query = "")
        {
            var model = await storeService.GetBookCardsPageAsync(page, query, BooksPerPageDefault);

            return View();
        }

        public async Task<IActionResult> Item(int Id)
        {

            return View();
        }

    }
}
