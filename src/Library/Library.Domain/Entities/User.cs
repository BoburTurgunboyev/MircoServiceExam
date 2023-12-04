using Library.Domain.Enums;

namespace Library.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public int UserAge { get; set; }
        public string UserAdress { get; set; }
        public string Email { get; set; }
        public string UserPhone { get; set; }
        public Role UserRole { get; set; }

        public ICollection<User_Book> User_Books { get; set; }


    }
}
