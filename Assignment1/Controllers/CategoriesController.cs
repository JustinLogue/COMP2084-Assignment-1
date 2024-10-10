using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()

        {
            var categories =CategoryRepo.GetCategories();
            return View(categories);
        }

        public IActionResult Edit(int? id)
        {
            var category = new Category { CategoryId = id.HasValue?id.Value:0 };
            return View(category);

        }
        public IActionResult Edit(Category category)
        {
            CategoryRepo.UpdateCategory(category.CategoryId, category);
            return RedirectToAction("Index");
        }
    }
}
