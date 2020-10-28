using MyIndeed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace MyIndeed.Controllers
{
    public class JobController : Controller
    {
        private ApplicationDbContext _context;
        public JobController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Job
        public ActionResult Index()
        {
            var jobs = _context.Jobs;
            return View(jobs);
        }
        public ActionResult Description(int Id)
        {
            Job job = _context.Jobs.SingleOrDefault(j => j.Id == Id);
            return View(job);
        }
        [Authorize]
        public ActionResult PostJob()
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public ActionResult PostJob(Job job)
        {
            if (ModelState.IsValid)
            {
                var userId = User.Identity.GetUserId();
                job.PostUser = _context.Users.Find(userId);
                _context.Jobs.Add(job);
                _context.SaveChanges();
                return RedirectToAction("Index", "Job");
            }
            return View("PostJob");

        }
    }
}