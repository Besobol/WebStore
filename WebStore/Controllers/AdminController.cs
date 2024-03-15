using Microsoft.AspNetCore.Mvc;
using WebStore.Core.Contracts;
using WebStore.Core.Models;

namespace WebStore.Controllers
{
    public class AdminController : BaseController
    {
        readonly IAdminService adminService;

        public AdminController(IAdminService _adminService)
        {
            adminService = _adminService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddAuthor()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddAuthor(AuthorModel model)
        {

            await adminService.AddAuthorAsync(model);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult AddPublisher() 
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddPublisher(PublisherModel model)
        {

            await adminService.AddPublisherAsync(model);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult AddStore()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddStore(StoreModel model)
        {

            await adminService.AddStoreAsync(model);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddBook(BookModel model)
        {
            await adminService.AddBookAsync(model);

            return RedirectToAction(nameof(Index));
        }
    }
}
