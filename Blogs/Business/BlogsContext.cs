using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Blogs
{
    public class BlogsContext:DbContext
    {
        static BlogsContext()
        {
            Database.SetInitializer<BlogsContext>(null);
        }

        public DbSet<Models.Blog> blogs { get; set; }

        public DbSet<Models.Comment> comments { get; set; }

        public DbSet<Models.Tag> tags { get; set; }
    }
}