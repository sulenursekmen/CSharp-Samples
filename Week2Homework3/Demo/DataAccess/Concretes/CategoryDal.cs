using Demo.DataAccess.Abstracts;
using Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        private List<Category> categories = new List<Category>();

        public void AddCategory(Category category)
        {
            categories.Add(category);
        }

        public void UpdateCategory(Category category)
        {
            var categoryToUpdate = categories.Find(c => c.Id == category.Id);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.Name = category.Name;
            }
        }

        public void DeleteCategory(int id)
        {
            var categoryToRemove = categories.Find(c => c.Id == id);
            if (categoryToRemove != null)
            {
                categories.Remove(categoryToRemove);
            }
        }

        public Category GetCategoryById(int id)
        {
            return categories.Find(c => c.Id == id);
        }

        public List<Category> GetAllCategories()
        {
            return categories;
        }
    }
}
