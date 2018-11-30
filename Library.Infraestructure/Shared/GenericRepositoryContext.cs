using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Infraestructure.Shared
{
    public abstract class GenericRepositoryContext : DbContext
    {

        public GenericRepositoryContext(DbContextOptions options) : base(options)
        {
        }

        public GenericRepositoryContext()
        {
        }


    }
}
