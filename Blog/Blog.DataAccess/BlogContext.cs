using Blog.Entities;

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccess
{
    public class BlogContext : DbContext
    {
        public BlogContext()
            : base("BlogDB")
        {
        }

        public DbSet<Article> Article { get; set; }
        public DbSet<Comment> Comment { get; set; }
    }
}
