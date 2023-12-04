namespace Library.Domain.Entities
{
    public class Library
    {
        public int Id { get; set; }
        public string LibraryName { get; set; }
        public string LibraryNumber { get; set; }
        public string Location { get; set; }
        public ICollection<BookCategory> BookCategories { get; set; }

    }
}
