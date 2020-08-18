using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eNews.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eNews.Repositories
{
    public class NewsRepository : INewsRepository
    {
        private AppDbContext _appDbContext;

        public NewsRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Add(NewsIndexListingModel news)
        {
            _appDbContext.News.Add(news);
            _appDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var data = _appDbContext.News.Find(id);
            _appDbContext.News.Remove(data);
            _appDbContext.SaveChangesAsync();
        }

        public void Edit(int id, NewsIndexListingModel request)
        {
            var result = _appDbContext.News.Where(x => x.Id == id);

            var entity = result.FirstOrDefault();

            _appDbContext.News.Attach(entity);
            _appDbContext.News.Update(entity);

            _appDbContext.SaveChanges();
        }

        public IEnumerable<NewsIndexListingModel> GetAll()
        {
            return _appDbContext.News.Include(a => a.User).ToList();
        }

        public NewsIndexListingModel GetById(int id)
        {
            return _appDbContext.News
                .Include(a => a.User)
                .FirstOrDefault(a => a.Id == id);
        }

        public List<NewsIndexListingModel> SearchNews(string search)
        {
            return _appDbContext.News
                            .Where(p => p.Title.Contains(search) || p.Keywords.Contains(search))
                            .ToList();
        }
    }
}
