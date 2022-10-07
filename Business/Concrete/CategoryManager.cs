using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : IGenericService<Category>, ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category entity)
        {
            _categoryDal.Add(entity);
        }

        public List<Category> GetAllEntities()
        {
            return _categoryDal.GetAll();
        }

        public Category GetEntityById(int id)
        {
            return _categoryDal.Get(x=>x.CategoryId==id);
        }

        public void Remove(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public void Update(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
