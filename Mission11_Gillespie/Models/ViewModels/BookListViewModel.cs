namespace Mission11_Gillespie.Models.ViewModels
{
    public class BookListViewModel
    {
        public IQueryable<Book> Books { get; set;}

        public PaginationInformation PaginationInformation { get; set;} = new PaginationInformation();
    }
}
