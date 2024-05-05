using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers;
    public class HomeController : Controller
    {
    private ILibrarianStorage _librarianStorage;

    public HomeController(ILibrarianStorage librarianStorage)
    {
        _librarianStorage= librarianStorage;
    }
    public JsonResult Index()
    {
        return Json(_librarianStorage.GetAllLibrarian());
    }

    public IActionResult Detail()
    {
        var students = _librarianStorage.GetAllLibrarian();
        return View(students);
    }
}

