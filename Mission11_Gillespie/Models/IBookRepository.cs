namespace Mission11_Gillespie.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
