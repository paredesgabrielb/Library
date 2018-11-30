using Library.Application.Shared;
using Library.Domain;
using Library.Infraestructure.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Books
{
    public class PageAppServices : IPageAppServices
    {
        private readonly IEntityRepository<Page, long> _pageRepository;

        public async Task<IEnumerable<Page>> GetAllPages()
        {
            return await _pageRepository.GetAllAsync();
        }
    }
}
