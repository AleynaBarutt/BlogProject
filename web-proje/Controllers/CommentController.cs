﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_proje.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]

        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
        [HttpPost]

        public IActionResult PartialAddComment(Comment p)
        {
            p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.CommentStatus = true;
            p.BlogID = 2;
            cm.CommmentAdd(p);
            return RedirectToAction("Index","Blog");
        }

        public PartialViewResult CommentListByBlog(int id)
        {
            var values = cm.GetList(id);

            return PartialView(values);
        }
    }
}
