using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author
        BlogManager bm = new BlogManager();
        public PartialViewResult AuthorAbout(int id)
        {
            var authordetails=bm.GetBlogByID(id);
            return PartialView(authordetails);
        }
        public PartialViewResult AuthorPopulerPost(int id)
        {
            var blogauthorid=bm.GetAll().Where(x=>x.BlogID==id).Select(y=>y.AuthorID).FirstOrDefault();

            var authorblogs = bm.GetBlogByAuthor(blogauthorid);

            return PartialView(authorblogs);
        }
    }
}