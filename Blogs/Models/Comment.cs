using System;

namespace Blogs.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public int Type { get; set; }
        public string BlogId { get; set; }
        public DateTime CreateTime { get; set; }

        public virtual Blog Blog { get; set; }
    }
}