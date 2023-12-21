using BookStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DL.Interfaces
{
    public interface IAuthorRepository
    {
        public void AddAuthor(Author author);

        public void DeleteAuthor(int id);

        public void UpdateAuthor(Author author);

        public Author? GetAuthor(int id);

        public List<Author> GetAllAuthors();
    }
}
