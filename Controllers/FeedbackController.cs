using System.Collections.Generic;
using System.Web.Mvc;
using StudentFeedbackManagement.Models;

namespace StudentFeedbackManagement.Controllers
{
    public class FeedbackController : Controller
    {
        // Store feedback data
        private static List<Feedback> feedbackList = new List<Feedback>();

        // 1. Index Action Method
        public ActionResult Index()
        {
            return View();
        }

        // 2. Create - HTTP GET
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // 3. Create - HTTP POST
        [HttpPost]
        public ActionResult Create(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                feedbackList.Add(feedback);

                return RedirectToAction("List");
            }

            return View(feedback);
        }

        // 4. List Action Method
        public ActionResult List()
        {
            return View(feedbackList);
        }
    }
}