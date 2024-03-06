using Microsoft.AspNetCore.Mvc;
using WebStore.Core.Models;

namespace WebStore.Controllers
{
    public class AdminController : BaseController
    {
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
        public IActionResult AddAuthor(AuthorModel model)
        {

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult AddPublisher() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPublisher(PublisherModel model)
        {

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult AddStore()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStore(StoreModel model)
        {

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBook(BookModel model)
        {

            return RedirectToAction(nameof(Index));
        }
    }
}
