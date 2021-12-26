using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_proje.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIClass : ControllerBase
    {

        [HttpGet]
        public ActionResult<List<string>> GetAllCategories()
        {
            Context c = new Context();
            var categoryNames = c.Categories.Select(m => m.CategoryName).Distinct().ToList();
            return  categoryNames;
        }

        [HttpPost]
        public void CreateCategory(string categoryName, string categoryDescription )
        {
            Context c = new Context();
            c.Categories.Add(new EntityLayer.Concrete.Category
                                {
                                    CategoryName = categoryName,
                                    CategoryDescription = categoryDescription,
                                    CategoryStatus = true
                                });

        }

    }
}
