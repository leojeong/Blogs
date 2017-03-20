using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blogs
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (BlogsContext db = new BlogsContext())
            {
                List<Models.Blog> newblogs = new List<Models.Blog> {
                    new Models.Blog() {  ID=1, Author="曾好", Content="dsafdaffsa", CoverImg="d", CreateTime=DateTime.Now, TagId="1", Title="dsfsdfs " , UpdateTime=DateTime.Now},
                    new Models.Blog() {  ID=2, Author="曾好1", Content="dsafdaffsa", CoverImg="d", CreateTime=DateTime.Now, TagId="1", Title="dsfsdfs " , UpdateTime=DateTime.Now},
                    new Models.Blog() {  ID=3, Author="曾好2", Content="dsafdaffsa", CoverImg="d", CreateTime=DateTime.Now, TagId="1", Title="dsfsdfs " , UpdateTime=DateTime.Now}
                };
                newblogs.ForEach(b => db.blogs.Add(b));
                db.SaveChanges();

                var blogs = from b in db.blogs
                            orderby b.CreateTime descending
                            select b;

            }
        }
    }
    public class A{}
}