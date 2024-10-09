namespace Assignment1.Models
{
    public class CategoryRepo
    {
        private static List<Category> _categories = new List<Category>() {
        new Category {CategoryId = 0, Name = "Work"},
        new Category {CategoryId = 1, Name = "Chores"},
        new Category {CategoryId = 2, Name = "Creativity"},
        new Category {CategoryId = 3, Name = "School"},
        new Category {CategoryId = 4, Name = "Misc"},
        };

        public static void AddCatergory(Category catergory)
        {
            var maxId = _categories.Max(x => x.CategoryId);
            catergory.CategoryId = maxId + 1;
            _categories.Add(catergory);
        }

        public static List<Category> GetCategories() => _categories;

        public static Category? GetCategoryById(int CatergoryId)
        {
            var category = _categories.FirstOrDefault(x => x.CategoryId == CatergoryId);
            if (category != null)
            {
                return new Category
                {
                    CategoryId = category.CategoryId,
                    Name = category.Name
                };
            }
            return null;
        }

        public static void UpdateCategory(int CategoryId, Category category)
        {
            if (CategoryId != category.CategoryId) return;

            var updatedCategory = GetCategoryById(CategoryId);
            if (updatedCategory != null)
            {
                {
                    updatedCategory.Name = category.Name;
                }
            }
        }
        public static void DeleteCategory(int CategoryId)
        {
            var category =_categories.FirstOrDefault(x =>x.CategoryId == CategoryId);
            if (category != null)
            {
                _categories.Remove(category);
            }
        }
    }
}
