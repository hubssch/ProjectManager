using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectManager.Areas.Identity.Data;
using ProjectManager.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static NuGet.Packaging.PackagingConstants;

namespace ProjectManager.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly ApplicationDBContext _context;
        public AdminController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: AdminController
        [AllowAnonymous]
        public ActionResult Index()
        {
            var projects = _context.Projects.Include(c => c.Category).Include(c => c.Employee);

            return View(projects.ToList());
        }

        // GET: AdminController/Details/5
        [AllowAnonymous]
        public ActionResult Details(int id)
        {
            return View(_context.Projects.Include(c => c.Category).Include(c => c.Employee).FirstOrDefault(x => x.Id == id));
        }

        // GET: AdminController/Create
        public ActionResult Create()
        {
            ViewBag.OptionsCategories = _context.Categories;
            ViewBag.OptionsEmployees = _context.Employees;

            return View();
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Projects project)
        {
            try
            {
                _context.Projects.Add(project);
                _context.SaveChanges();
                return RedirectToAction("Index");
  
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.OptionsCategories = _context.Categories;
            ViewBag.OptionsEmployees = _context.Employees;
            return View(_context.Projects.Find(id));
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Projects project)
        {
            try
            {
                _context.Projects.Update(project);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_context.Projects.Include(c => c.Category).Include(c => c.Employee).FirstOrDefault(x => x.Id == id));
        }

        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Projects project)
        {
            try
            {
                _context.Projects.Remove(project);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
