using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
        private EfCategoryRepository efCategoryRepository;
        private EfCommentRepository efCommentRepository;
        private Expression<Func<Category, bool>> category;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public CategoryManager(EfCategoryRepository efCategoryRepository)
        {
            this.efCategoryRepository = efCategoryRepository;
        }

        public CategoryManager(EfCommentRepository efCommentRepository)
        {
            this.efCommentRepository = efCommentRepository;
        }

        public void CategoryAdd(Category category)
        {
            _categoryDal.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetByID(id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetListAll();
        }
    }
}
