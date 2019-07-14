
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeddingPlanner.Models;

namespace WeddingPlanner.Controllers
{
    [Route("weddings")]
    public class WeddingController : Controller
    {
        private User loggedInUser
        {
            get { return dbContext.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("UserId")); }

        }
        private WeddingPlannerContext dbContext;
        public WeddingController(WeddingPlannerContext context)
        {
            dbContext = context;
        }
        // localhost:500/weddings

        [HttpGet("")]
        public IActionResult Index()
        {
            //if no key in session redirect back to Home->Index
            if (loggedInUser == null)
                return RedirectToAction("Index", "Home");
            ViewBag.UserId = loggedInUser.UserId;
            var allWeddings = dbContext.Weddings
                .Include(w => w.Responses)
                .Include(w => w.Planner)
                .OrderByDescending(w => w.Date)
                .ToList();

            // var usersWeddings = allWeddings.Where(w => w.Responses.Any(r => r.UserId == loggedInUser.UserId));

            ViewBag.AllWeddings = allWeddings;

            return View(allWeddings);
        }

        [HttpGet("/newWedding")]
        public IActionResult newWedding()
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            ViewBag.Id = UserId;
            return View("newWedding");
        }


        [HttpGet("{weddingId}")]
        public IActionResult Show(int weddingId)
        {
            //query for wedding with wedding id
            //include Responses
            //Then include R.Guess

            var viewModel = dbContext.Weddings
                .Include(w => w.Responses)
                .ThenInclude(r => r.Guest)
                .Include(w => w.Planner)
                .FirstOrDefault(w => w.WeddingId == weddingId);


            return View(viewModel);
        }


        [HttpGet("delete/{weddingId}")]
        public IActionResult Delete(int weddingId)
        {
            //query to wedding with wedding id
            Wedding toDelete = dbContext.Weddings
                .FirstOrDefault(w => w.WeddingId == weddingId);

            dbContext.Weddings.Remove(toDelete);
            dbContext.SaveChanges();
            //delete it
            return RedirectToAction("Index");
        }


        [HttpPost("/createWedding")]
        public IActionResult CreateWedding(Wedding wedding)
        {
            if (ModelState.IsValid)
            {

                wedding.UserId = (int)loggedInUser.UserId;
                dbContext.Add(wedding);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("newWedding");
        }


        [HttpGet("/rsvp/{weddingId}")]

        public IActionResult Rsvp(int weddingId, int userid)
        {
            //is user actually in session
            if (loggedInUser == null)
                return RedirectToAction("Index");

            Response rsvp = new Response()
            {
                UserId = loggedInUser.UserId,
                WeddingId = weddingId
            };
            dbContext.Responses.Add(rsvp);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("/unrsvp/{weddingId}")]

        public IActionResult Unrsvp(int weddingId, int userId)
        {
            //is user actually in session
            if (loggedInUser == null)
                return RedirectToAction("Index");

            // query for response to delete
            Response toRemove = dbContext.Responses.FirstOrDefault(
                r => r.WeddingId == weddingId &&
                     r.UserId == loggedInUser.UserId
            );
            if (toRemove == null)
                return RedirectToAction("Index");

            dbContext.Responses.Remove(toRemove);
            dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet("logout")]
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return Redirect("/");
        }

        [HttpGet("portfolioo")]
        public IActionResult Portfolioo()
        {
            return Redirect("http://18.220.137.34/");
        }

        [HttpGet("about")]
        public IActionResult About()
        {
            return Redirect("http://18.220.137.34/about/");
        }

        [HttpGet("python")]
        public IActionResult Python()
        {
            return Redirect("http://18.220.137.34/python/");
        }

        [HttpGet("csharp")]
        public IActionResult Csharp()
        {
            return Redirect("http://18.220.137.34/csharp/");
        }


        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return Redirect("http://18.220.137.34/about/Pdf");
        }

    }
}