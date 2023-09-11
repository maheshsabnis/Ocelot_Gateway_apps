using CategoryService.Models;

namespace CategoryService.Database
{
    public class Categories : List<Category>
    {
        public Categories()
        {
            Add(new Category() { CategoryId=1,CategoryName="C1",BasePrice=10900});
            Add(new Category() { CategoryId = 2, CategoryName = "C2", BasePrice = 20900 });
            Add(new Category() { CategoryId = 3, CategoryName = "C3", BasePrice = 30900 });
        }
    }

   
}
