﻿using MDS.Data;
using MDS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Data;

namespace MDS.Controllers
{
    public class TariController : Controller
    {
        private readonly ApplicationDbContext db;

        private readonly UserManager<ApplicationUser> _userManager;

        private readonly RoleManager<IdentityRole> _roleManager;

        public TariController(
            ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager
            )
        {
            db = context;

            _userManager = userManager;

            _roleManager = roleManager;
        }

        [Authorize(Roles = "User,Agent,Admin")]

        public IActionResult Index()
        {
            var search = "";
            var tari = db.ListaTari.OrderBy(a => a.Nume).ToList();

            if (!string.IsNullOrEmpty(HttpContext.Request.Query["search"]))
            {
                search = HttpContext.Request.Query["search"].ToString().Trim();
                List<int> tariid = db.ListaTari.Where(t => t.Nume.Contains(search))
                    .Select(a => a.Id).ToList();
                tari = db.ListaTari.Where(t => tariid.Contains(t.Id)).ToList();
            }

            ViewBag.SearchString = search;
            int _perPage = 8;
            if (TempData.ContainsKey("message"))
            {
                ViewBag.message = TempData["message"].ToString();
            }
            int totalItems = tari.Count();

            // Get the current page number from the query parameter
            int currentPage;
            if (!int.TryParse(HttpContext.Request.Query["page"], out currentPage) || currentPage < 1)
            {
                currentPage = 1; // Set a default value if the page parameter is invalid or not present
            }

            var offset = (currentPage - 1) * _perPage;
            var paginatedArticles = tari.Skip(offset).Take(_perPage);
            ViewBag.lastPage = Math.Ceiling((float)totalItems / (float)_perPage);
            ViewBag.Tari = paginatedArticles;

            if (search != "")
            {
                if (totalItems == 0)
                {
                    TempData["message"] = "Nu s-a găsit țara care conține cuvântul: " + search;
                    return RedirectToAction("Index");
                }

                ViewBag.PaginationBaseUrl = "/Tari/Index/?search=" + search + "&page";
            }
            else
            {
                ViewBag.PaginationBaseUrl = "/Tari/Index/?page";
            }

            ViewBag.CurrentPage = currentPage; // Pass the current page number to the view

            return View();
        }

        [Authorize(Roles = "User,Agent,Admin")]
        public IActionResult Show(int id)
        {
            SetAccessRights();

            if (User.IsInRole("User") || User.IsInRole("Agent") || User.IsInRole("Admin"))
            {
                var tara = db.ListaTari.Where(t => t.Id == id).FirstOrDefault();
                int _perPage = 8;

                var listaHoteluri = db.ListaHoteluri.Where(h => h.TaraId == id).ToList();

                if (listaHoteluri.Count == 0)
                {
                    TempData["message"] = "Nu există hoteluri pentru țara selectată";
                    return RedirectToAction("Index", "Tari");
                }

                int totalItems = listaHoteluri.Count();

                int currentPage;
                if (!int.TryParse(HttpContext.Request.Query["page"], out currentPage) || currentPage < 1)
                {
                    currentPage = 1; // Set a default value if the page parameter is invalid or not present
                }

                var offset = (currentPage - 1) * _perPage;
                var paginatedHoteluri = listaHoteluri.Skip(offset).Take(_perPage);

                ViewBag.LastPage = Math.Ceiling((float)totalItems / (float)_perPage);
                ViewBag.Hotels = paginatedHoteluri;
                ViewBag.CurrentPage = currentPage; // Pass the current page number to the view
                ViewBag.PaginationBaseUrl = $"/Tari/Show/{id}?page=";

                return View(tara);
            }
            else
            {
                TempData["message"] = "Nu aveți drepturi";
                return RedirectToAction("Index", "Tari");
            }
        }



        [Authorize(Roles = "Admin")]
        public IActionResult New()
        {

            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult New(Tara tr)
        {
            tr.UserId = _userManager.GetUserId(User);

            if (ModelState.IsValid)
            {
                db.ListaTari.Add(tr);
                db.SaveChanges();
                TempData["message"] = "Țara a fost adăugată";
                return RedirectToAction("Index");
            }

            else
            {
                return View(tr);
            }
        }


        private void SetAccessRights()
        {
            ViewBag.AfisareButoane = false;

            if (User.IsInRole("User"))
            {
                ViewBag.AfisareButoane = true;
            }

            ViewBag.EsteAdmin = User.IsInRole("Admin");

            ViewBag.UserCurent = _userManager.GetUserId(User);
        }


        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id)
        {
            Tara tara = db.ListaTari.Where(art => art.Id == id)
                                         .First();

            if (tara.UserId == _userManager.GetUserId(User) || User.IsInRole("Admin"))
            {
                db.ListaTari.Remove(tara);
                db.SaveChanges();
                TempData["message"] = "Țara a fost ștearsă";
                return RedirectToAction("Index");
            }

            else
            {
                TempData["message"] = "Nu aveți dreptul să ștergeți o țară";
                return RedirectToAction("Index");
            }
        }

        public IActionResult Edit(int id)
        {

            Tara tara = db.ListaTari.Include("Hotel")
                                        .Where(art => art.Id == id)
                                        .First();

            if (tara.UserId == _userManager.GetUserId(User) || User.IsInRole("Admin"))
            {
                return View(tara);
            }
            else
            {
                TempData["message"] = "Nu puteți edita această țară";
                return View(tara);
            }

        }
    }
}
