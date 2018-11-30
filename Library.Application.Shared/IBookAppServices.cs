using Library.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Library.Application.Shared
{
    public interface IBookAppServices
    {
        Task<IEnumerable<Book>> GetAllBooks();
    }
}
