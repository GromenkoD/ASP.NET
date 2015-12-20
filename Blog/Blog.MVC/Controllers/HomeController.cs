using Blog.DataAccess;
using Blog.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.MVC.Controllers
{
    public class HomeController : Controller
    {
        //
        private BlogContext _blogContext = new BlogContext();
        public ActionResult Index()
        {
            return View(_blogContext.Article);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Article article)
        {
            if (ModelState.IsValid)
            {
                _blogContext.Article.Add(article);
                _blogContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(article);
        }
        public ActionResult CreateComment()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateComment(Comment comment, int id)
        {
            comment.ArticleId = id;
            if (ModelState.IsValid)
            {
                _blogContext.Comment.Add(comment);
                _blogContext.SaveChanges();
                return RedirectToAction("Details", "Home", new { id = id });
            }
            return View(comment);
        }

        //public ActionResult _PartialComment(int id, string name)
        //{
        //    Comment comment = new Comment();
        //    comment.ArticleId = id;
        //    comment.Content = name;
        //    _blogContext.Comment.Add(comment);
        //    _blogContext.SaveChanges();
        //    return PartialView(comment);
        //}
        public ActionResult _PartialAddComment(int id, string name)
        {
            Comment comment = new Comment();
            comment.ArticleId = id;
            comment.Content = name;
            _blogContext.Comment.Add(comment);
            _blogContext.SaveChanges();

            ViewBag.Comment = comment;
            return PartialView();
        }
        public ActionResult Details(int id = 0)
        {

            Article article = _blogContext.Article.Find(id);
            Comment comment = _blogContext.Comment.Find(id);

            if (article == null)
            {
                return HttpNotFound();
            }

            //article.Comments = _blogContext.Comment.Where(m => m.ArticleId == article.Id);

            return View(article);
        }

        public ActionResult Delete(int id = 0)
        {
            Article article = _blogContext.Article.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Article product = _blogContext.Article.Find(id);
            _blogContext.Article.Remove(product);
            _blogContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id = 0)
        {
            Article article = _blogContext.Article.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Article article)
        {
            if (ModelState.IsValid)
            {
                _blogContext.Entry(article).State = EntityState.Modified;
                _blogContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(article);
        }



        protected override void Dispose(bool disposing)
        {
            _blogContext.Dispose();
            base.Dispose(disposing);
        }

    }
}
