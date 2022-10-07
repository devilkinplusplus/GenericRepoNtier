using Entities.Concrete;

namespace WebAPI.ViewModels
{
    public class BookUpdatedVM
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
    }
}
