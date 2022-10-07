using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BookManager : IGenericService<Book>, IBookService
    {
        private readonly IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public void Add(Book entity)
        {
            _bookDal.Add(entity);
        }

        public List<Book> GetAllEntities()
        {
            return _bookDal.GetAll();
        }

        public Book GetEntityById(int id)
        {
            return _bookDal.Get(x => x.BookId == id);
        }

        public void Remove(Book entity)
        {
            _bookDal.Delete(entity);
        }

        public void Update(Book entity)
        {
            _bookDal.Update(entity);
        }
    }
}
