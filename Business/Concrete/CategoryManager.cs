using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryService _categoryService;

        public CategoryManager(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public List<Category> GetAll()
        {
            return _categoryService.GetAll();
        }
    }
}
