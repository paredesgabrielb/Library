using Library.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Shared
{
    public interface IPageAppServices
    {
        Task<IEnumerable<Page>> GetAllPages();
    }
}
