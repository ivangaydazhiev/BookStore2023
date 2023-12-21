

using BookStore.Models.Models;

namespace BookStore.DL.InMemoryDb
{
    public class StaticData
    {
        public static List<Book> Books = new List<Book>()
        {
            new Book()
            {
                Id =1,
                Title = "Book1"
            },

             new Book()
            {
                Id =2,
                Title = "Book2"
            },
              new Book()
            {
                Id =3,
                Title = "Book3"
            }
        };

        public static List<Author> Authors = new List<Author>()
        {
            new Author()
            {
                Id =145,
                Name = "Ivan"
            },

             new Author()
            {
                Id =232,
                Name = "Dimitur"
            },
              new Author()
            {
                Id =358,
                Name = "Petar"
            }
        };
    }
}
