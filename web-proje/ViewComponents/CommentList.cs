using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_proje.Models;

namespace web_proje.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                     ID=1,
                     Username="Aleyna"

                },

                new UserComment
                {
                     ID=2,
                     Username="Ebru"

                },

                new UserComment
                {
                     ID=3,
                     Username="Merve"

                }

            };
            return View(commentvalues);
        }
    }
}
