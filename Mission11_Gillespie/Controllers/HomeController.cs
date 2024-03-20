using Microsoft.AspNetCore.Mvc;
using Mission11_Gillespie.Models;
using Mission11_Gillespie.Models.ViewModels;
using System.Diagnostics;

namespace Mission11_Gillespie.Controllers
{
    public class HomeController : Controller
    {
        public IBookRepository _bookrepo;
        public HomeController(IBookRepository temp)
        {
            _bookrepo = temp;
        }

        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;
            var tagsPlusData = new BookListViewModel
            {
                Books = _bookrepo.Books
                .OrderBy(x => x.Title)
                .Skip(pageSize * (pageNum - 1))
                .Take(pageSize),

                PaginationInformation = new PaginationInformation
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _bookrepo.Books.Count()
                }
            };
            return View(tagsPlusData);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
