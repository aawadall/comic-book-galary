using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGalary.Controllers
{
    public class ComicBooksController:Controller
    {
        public ActionResult Detail()
        {
            ViewBag.SeriesTitle = "my Deen";
            ViewBag.IssueNumber = "2371-8978";
            ViewBag.Description = "<div>August 2017, Ages 8-11</div></div><h3>Sharing is caring</h3>";
            ViewBag.Artists = new string[]
            {
                "Artist 1",
                "Artist 2",
                "Artist 3",
                "Artist 4",
                "Artist 5",
                "Artist 6"
            };
            return View();
        }
    }
}