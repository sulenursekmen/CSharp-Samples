using Demo.DataAccess.Abstracts;
using Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Business
{
    public class CategoryManager : ICategoryDal
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void AddCategory(Category category)
        {
            _categoryDal.AddCategory(category);
        }

        public void UpdateCategory(Category category)
        {
            _categoryDal.UpdateCategory(category);
        }

        public void DeleteCategory(int id)
        {
            _categoryDal.DeleteCategory(id);
        }

        public Category GetCategoryById(int id)
        {
            return _categoryDal.GetCategoryById(id);
        }

        public List<Category> GetAllCategories()
        {
            return _categoryDal.GetAllCategories();
        }
    }
}
