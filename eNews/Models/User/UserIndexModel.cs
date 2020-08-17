using eNews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eNews.Data.Models.User
{
    public class UserIndexModel
    {
        public IEnumerable<UserIndexListingModel> Users { get; set; }
    }
}
