using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using adstra_task.Core;

namespace adstra_task.Data.SqlServerEF
{
   public  class EDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = localhost; Initial Catalog= Repo; Integrated Security=True ; Pooling=False");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Authors> Authors { get; set; }
        public DbSet<AuthorPost> authorPosts { get; set; }

    }
}
