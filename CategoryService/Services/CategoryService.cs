using CategoryService.Database;
using CategoryService.Models;
using Microsoft.EntityFrameworkCore;

namespace CategoryService.Services
{
    public class CategoryRepoService  
    {

        Categories cats = new Categories();

        public IEnumerable<Category> GetCategories()
        {
            return cats;
        }

        public IEnumerable<Category> AddCategory(Category c)
        {
            cats.Add(c);
            return cats;
        }
    }
}
