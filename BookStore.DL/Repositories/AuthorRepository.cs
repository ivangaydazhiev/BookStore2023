using BookStore.DL.InMemoryDb;
using BookStore.DL.Interfaces;
using BookStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DL.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        public void AddAuthor(Author author)
        {
            StaticData.Authors.Add(author);
        }

        public void DeleteAuthor(int id)
        {
            var author = StaticData.Authors
                .FirstOrDefault(b => b.Id == id);

            if (author== null) return;

            StaticData.Authors.Remove(author);
        }


        public List<Author> GetAllAuthors()
        {
            return StaticData.Authors;
        }

     

        public Author? GetAuthor(int id)
        {
            return
                StaticData.Authors
                 .FirstOrDefault(b => b.Id == id);
        }

        public void UpdateAuthor(Author author)
        {
            var existingAuthor =
                StaticData.Authors
                .FirstOrDefault(b => b.Id == author.Id);

            if (existingAuthor == null) return;

            existingAuthor.Name = author.Name;
        }
    }
}
 

