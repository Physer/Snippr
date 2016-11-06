using System;
using System.Data.Entity;
using Snippr.Domain.Models;

namespace Snippr.Data
{
    public class SnipprContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CodeSnippet> CodeSnippets { get; set; }

        public SnipprContext() : base("DefaultContext")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SnipprContext>());
        }
    }
}
