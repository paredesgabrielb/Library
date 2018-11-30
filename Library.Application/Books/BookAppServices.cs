using Library.Application.Shared;
using Library.Domain;
using Library.Infraestructure.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Books
{
    public class BookAppServices : IBookAppServices
    {
        private readonly IEntityRepository<Book, int> _bookRepository;

        public BookAppServices(IEntityRepository<Book, int> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _bookRepository.GetAllAsync();
        }
    }
}
