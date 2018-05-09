using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuySchoolMaterial.Data;
using BuySchoolMaterial.Models;
using BuySchoolMaterial.Models.AppViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BuySchoolMaterial.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public UserController(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }










        public async Task<IActionResult> Dashboard()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var viewModel = new DashboardViewModel
            {
                UserName = user.UserName,
                Location=user.Location,
                Name=user.FullName,
                Contact=user.PhoneNumber,
                NoOfMaterials= _context.Materials.Where(x => x.OwnerId == user.Id).Count(),
                NoOfFavMaterials = _context.Materials.Where(x => x.OwnerId == user.Id && x.IsFav).Count(),
                Materials = _context.Materials.Where(x => x.OwnerId == user.Id).ToList(),
                AvailableRequestMaterials = _context.Requests.Where(x => x.RequsterId == user.Id).Select(y => _context.Materials.Single(a => a.Id == y.MaterialId && !a.IsSold)).ToList(),
                SoldRequestMaterial = _context.Requests.Where(x => x.RequsterId == user.Id).Select(y => _context.Materials.Single(a => a.Id == y.MaterialId && a.IsSold)).ToList(),
                SoldMaterials = _context.Materials.Where(x => x.OwnerId == user.Id && x.IsSold).ToList()
            };

            return View(viewModel);
        }




        [HttpGet]
        public IActionResult PostMaterial()
        {
            return View();
        }


        [HttpPost]
        public IActionResult PostMaterial(Material material)
        {

            return View();
        }




        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}