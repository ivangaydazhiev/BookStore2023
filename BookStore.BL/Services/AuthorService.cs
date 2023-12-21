using BookStore.BL.Interfaces;
using BookStore.DL.Interfaces;
using BookStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BL.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository)

        {
            _authorRepository = authorRepository;
        }
        public void AddAuthor(Author author)
        {
            _authorRepository.AddAuthor(author);
        }

        public void DeleteAuthor(int id)
        {
            _authorRepository.DeleteAuthor(id);
        }

        public List<Author> GetAllAuthors()
        {
            return _authorRepository.GetAllAuthors();
        }

        public Author? GetAuthor(int id)
        {
            return _authorRepository.GetAuthor(id);
        }

        public void UpdateAuthor(Author author)
        {
            _authorRepository.UpdateAuthor(author);
        }
    }
}
