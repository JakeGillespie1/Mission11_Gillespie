namespace Mission11_Gillespie.Models
{
    public class EFBookRepository : IBookRepository
    {
        private readonly BookstoreContext _context;
        public EFBookRepository(BookstoreContext temp) 
        { 
            _context = temp;
        }

        public IQueryable<Book> Books => _context.Books;
    }
}
