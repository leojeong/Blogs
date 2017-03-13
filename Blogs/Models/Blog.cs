using System;
using System.Collections.Generic;

namespace Blogs.Models
{
    public class Blog
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public string CoverImg { get; set; }
        public string TagId { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }

        public virtual List<Comment> Comments { get; set; }
        public virtual List<Tag> Tags { get; set; }
    }
}