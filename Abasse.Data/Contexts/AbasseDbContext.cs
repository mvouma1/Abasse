using Abasse.Domain.Entities.Catalog;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abasse.Data.Contexts
{
    public class AbasseDbContext:DbContext
    {
        public AbasseDbContext(DbContextOptions<AbasseDbContext> builder)
            : base(builder)
        { }
            public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {

        }
    }
}
