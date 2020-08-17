using eNews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eNews.Data.Models.News
{
    public class NewsIndexModel
    {
        public IEnumerable<NewsIndexListingModel> News { get; set; }
    }
}