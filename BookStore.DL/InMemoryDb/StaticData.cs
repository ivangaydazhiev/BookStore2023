

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
                Title = "Book1",
                AuthorId = 1,
                ReleaseDate = new DateTime(2005,05,07)
            },

             new Book()
            {
                Id =2,
                Title = "Book2",
                AuthorId = 2,
                ReleaseDate = new DateTime(2007,05,07)
            },
              new Book()
            {
                Id =3,
                Title = "Book3",
                AuthorId = 3,
                ReleaseDate = new DateTime(2010,05,07)
            }
        };

        public static List<Author> Authors = new List<Author>()
        {
            new Author()
            {
                Id =1,
                Name = "Ivan"
            },

             new Author()
            {
                Id =2,
                Name = "Dimitur"
            },
              new Author()
            {
                Id =3,
                Name = "Petar"
            }
        };
    }
}
