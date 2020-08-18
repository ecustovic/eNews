using eNews.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace eNews.Repositories
{
    public interface INewsRepository
    {
        IEnumerable<NewsIndexListingModel> GetAll();
        void Add(NewsIndexListingModel News);
        void Edit(int id, NewsIndexListingModel request);
        NewsIndexListingModel GetById(int id);
        void Delete(int id);
        List<NewsIndexListingModel> SearchNews(string search);
    }
}
