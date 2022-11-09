using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concretes;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ReservationOfTravel.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());

        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult AddComment(Comment comment)
        {
            comment.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            comment.CommentStatus = true;
            commentManager.Add(comment);
            return RedirectToAction("Index","Destination");
        }
    }
}
