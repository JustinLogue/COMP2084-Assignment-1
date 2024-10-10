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
        private static List<Task> _tasks = new List<Task>() { 
        //new Task {Id=1, Name="Upload Lastest Build", Description="Upload Lastest Bulid", Repeating= true, CategoryId = 1}
        };

        public static void AddCategory(Category category)
        {
            var maxId = _categories.Max(x => x.CategoryId);
            category.CategoryId = maxId + 1;
            _categories.Add(category);
        }

        public static List<Category> GetCategories() => _categories;

        public static Category? GetCategoryById(int categoryId)
        {
            var category = _categories.FirstOrDefault(x => x.CategoryId == categoryId);
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

        public static void UpdateCategory(int categoryId, Category category)
        {
            if (categoryId != category.CategoryId) return;

            var updatedCategory = _categories.FirstOrDefault(x => x.CategoryId ==categoryId);
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
