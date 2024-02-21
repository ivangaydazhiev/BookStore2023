using Amazon.Runtime.Internal;
using BookStore.DL.Configuration;
using BookStore.DL.Interfaces;
using BookStore.Models.Models;
using Microsoft.Extensions.Options;

namespace BookStore.DL.Repositories.Mongo
{
    public class BookMongoRepository : IBookRepository
    {

        private IOptions<MongoConfiguration> _mongoConfig;

        public BookMongoRepository(
            IOptions<MongoConfiguration> mongoConfig)
        {
            _mongoConfig = mongoConfig;
        }

        public void Add(Book book)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllByAuthor(int authorId)
        {
            throw new NotImplementedException();
        }

        public Book GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
