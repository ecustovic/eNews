using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eNews.Models;
using eNews.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eNews.Controllers
{
    [Authorize(Roles = "Admin")]
    public class NewsController : Controller
    {
        private INewsRepository _newsRepository;
        private readonly AppDbContext _db;

        [BindProperty]
        public NewsIndexListingModel News { get; set; }

        public NewsController(INewsRepository newsRepository, AppDbContext db)
        {
            _newsRepository = newsRepository;
            _db = db;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            IEnumerable<NewsIndexListingModel> news = _newsRepository.GetAll();

            return View(news);
        }

        public IActionResult Upsert(int? id)
        {
            News = new NewsIndexListingModel();
            if (id == null)
            {
                //create
                return View(News);
            }
            //update
            News = _db.News.FirstOrDefault(u => u.Id == id);
            if (News == null)
            {
                return NotFound();
            }
            return View(News);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert()
        {
            if (ModelState.IsValid)
            {
                if (News.Id == 0)
                {
                    //create
                    _db.News.Add(News);
                }
                else
                {
                    _db.News.Update(News);
                }
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(News);
        }

        //#region API Calls
        //[HttpGet]
        //public async Task<IActionResult> GetAll()
        //{
        //    return Json(new { data = await _db.News.ToListAsync() });
        //}

        //[HttpDelete]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var newsFromDb = await _db.News.FirstOrDefaultAsync(u => u.Id == id);
        //    if (newsFromDb == null)
        //    {
        //        return Json(new { success = false, message = "Error while Deleting" });
        //    }
        //    _db.News.Remove(newsFromDb);
        //    await _db.SaveChangesAsync();
        //    return Json(new { success = true, message = "Delete successful" });
        //}
        //#endregion
    }
}