﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_proje.ViewComponents.Writer
{
    public class WriterMessageNotification : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
