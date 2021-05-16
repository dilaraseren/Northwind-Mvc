using Microsoft.AspNetCore.Mvc;
using NetCoreMvc.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMvc.Controllers
{
    public class ProductController : Controller
    {
        Context c = new Context();

        public IActionResult Index()
        {
            var values = c.Products.ToList();
            return View(values);
        }
    }
}
