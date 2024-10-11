
using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()

        {
            var categories = CategoryRepo.GetCategories();
            return View(categories);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var category = new Category { CategoryId = id.HasValue ? id.Value : 0 };
            return View(category);

        }
        [HttpPost]
        public IActionResult Edit(Category category)
        {
            CategoryRepo.UpdateCategory(category.CategoryId, category);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Category category) 
        { 
            if (ModelState.IsValid)
            {
                CategoryRepo.AddCategory(category);
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        
        }
    }
}
