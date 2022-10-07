using Core.Entity;

namespace Entities.Concrete
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}